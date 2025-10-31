using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda;
using CommandLine;

namespace SpellsScrollsStaves
{
    public class Patchers
    {
        private const string TemplateEsp = "Spells Scrolls Staves - TnE - TEMPLATE.esp";

        // Centralized FormKey definitions
        private static class RecipeFormKeys
        {
            public static readonly FormKey Paper = FormKey.Factory($"000886:{TemplateEsp}");
            public static readonly FormKey Ink = FormKey.Factory($"000887:{TemplateEsp}");
            public static readonly FormKey Workbench = FormKey.Factory($"000888:{TemplateEsp}");
        }

        private static readonly Dictionary<string, string> SpellTiers = new()
        {
            {"Novice", "000"},
            {"Apprentice", "025"},
            {"Adept", "050"},
            {"Expert", "075"},
            {"Master", "100"}
        };

        private static readonly Dictionary<string, IFormLinkGetter<IPerkGetter>> EnchantmentTiers = new()
        {
            {"Novice", Skyrim.Perk.Enchanter00},
            {"Apprentice", Skyrim.Perk.Enchanter20},
            {"Adept", Skyrim.Perk.Enchanter40},
            {"Expert", Skyrim.Perk.Enchanter60},
            {"Master", Skyrim.Perk.Enchanter80}
        };

        // Helper method to get spell metadata
        private static (string School, string Level)? GetSpellMetadata(IFormLinkGetter<IPerkGetter>? perk)
        {
            if (perk is null) return null;

            // Extract from perk name (e.g., "AlterationNovice00" -> "Alteration", "Novice")
            // Map perks to metadata
            if (perk == Skyrim.Perk.AlterationNovice00) return ("Alteration", "Novice");
            if (perk == Skyrim.Perk.AlterationApprentice25) return ("Alteration", "Apprentice");
            if (perk == Skyrim.Perk.AlterationAdept50) return ("Alteration", "Adept");
            if (perk == Skyrim.Perk.AlterationExpert75) return ("Alteration", "Expert");
            if (perk == Skyrim.Perk.AlterationMaster100) return ("Alteration", "Master");

            if (perk == Skyrim.Perk.ConjurationNovice00) return ("Conjuration", "Novice");
            if (perk == Skyrim.Perk.ConjurationApprentice25) return ("Conjuration", "Apprentice");
            if (perk == Skyrim.Perk.ConjurationAdept50) return ("Conjuration", "Adept");
            if (perk == Skyrim.Perk.ConjurationExpert75) return ("Conjuration", "Expert");
            if (perk == Skyrim.Perk.ConjurationMaster100) return ("Conjuration", "Master");

            if (perk == Skyrim.Perk.DestructionNovice00) return ("Destruction", "Novice");
            if (perk == Skyrim.Perk.DestructionApprentice25) return ("Destruction", "Apprentice");
            if (perk == Skyrim.Perk.DestructionAdept50) return ("Destruction", "Adept");
            if (perk == Skyrim.Perk.DestructionExpert75) return ("Destruction", "Expert");
            if (perk == Skyrim.Perk.DestructionMaster100) return ("Destruction", "Master");

            if (perk == Skyrim.Perk.IllusionNovice00) return ("Illusion", "Novice");
            if (perk == Skyrim.Perk.IllusionApprentice25) return ("Illusion", "Apprentice");
            if (perk == Skyrim.Perk.IllusionAdept50) return ("Illusion", "Adept");
            if (perk == Skyrim.Perk.IllusionExpert75) return ("Illusion", "Expert");
            if (perk == Skyrim.Perk.IllusionMaster100) return ("Illusion", "Master");

            if (perk == Skyrim.Perk.RestorationNovice00) return ("Restoration", "Novice");
            if (perk == Skyrim.Perk.RestorationApprentice25) return ("Restoration", "Apprentice");
            if (perk == Skyrim.Perk.RestorationAdept50) return ("Restoration", "Adept");
            if (perk == Skyrim.Perk.RestorationExpert75) return ("Restoration", "Expert");
            if (perk == Skyrim.Perk.RestorationMaster100) return ("Restoration", "Master");

            return null;
        }

        public static void PatchTome(Book tome, ISpellGetter spell)
        {
            var metadata = GetSpellMetadata(spell.HalfCostPerk);

            if (metadata is null)
            {
                Console.WriteLine($"Warning: {spell.FormKey.IDString()} in {spell.FormKey.ModKey} is missing a school of magic");
                tome.Name = tome.Name?.String?.Replace("Spell Tome:", "Spell Tome of", StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                tome.Name = tome.Name?.String?.Replace("Spell Tome:", $"{metadata.Value.Level} Tome of", StringComparison.OrdinalIgnoreCase);
                tome.Keywords?.Add(Keywords.TomeSchools[spell.HalfCostPerk]);
                tome.Keywords?.Add(Keywords.TomeLevels[spell.HalfCostPerk]);
                tome.Keywords?.Add(Keywords.TomeTypes[spell.HalfCostPerk]);
            }
        }

        public static void ConstructTomeRecipe(Book tome, ISpellGetter spell, ISkyrimMod patch)
        {
            var metadata = GetSpellMetadata(spell.HalfCostPerk);
            if (metadata is null) return;

            var (school, level) = metadata.Value;

            var tomeRecipe = new ConstructibleObject(patch)
            {
                EditorID = $"_ANDR_{school[0]}{SpellTiers[level]}_{spell.Name?.String}_Tome_Recipe",
                Items =
                [
                    new ContainerEntry()
                    {
                        Item = new ContainerItem()
                        {
                            Item = RecipeFormKeys.Paper.ToNullableLink<IMiscItemGetter>(),
                            Count = 1
                        }
                    },
                    new ContainerEntry()
                    {
                        Item = new ContainerItem()
                        {
                            Item = RecipeFormKeys.Ink.ToNullableLink<IMiscItemGetter>(),
                            Count = 1
                        }
                    }
                ],
                Conditions =
                [
                    new ConditionFloat
                    {
                        CompareOperator = CompareOperator.GreaterThanOrEqualTo,
                        ComparisonValue = 1,
                        Data = new GetItemCountConditionData()
                        {
                            RunOnType = Condition.RunOnType.Subject,
                        }
                    },
                    new ConditionFloat
                    {
                        CompareOperator = CompareOperator.EqualTo,
                        ComparisonValue = 1,
                        Data = new HasPerkConditionData()
                        {
                            RunOnType = Condition.RunOnType.Reference,
                            Reference = Skyrim.PlayerRef,
                        }
                    }
                ],
                CreatedObject = tome.ToNullableLink<IBookGetter>(),
                WorkbenchKeyword = RecipeFormKeys.Workbench.ToNullableLink<IKeywordGetter>(),
                CreatedObjectCount = 1,
            };
            tomeRecipe.Conditions[0].Data.Cast<GetItemCountConditionData>().ItemOrList.Link.FormKey = tome.FormKey;
            tomeRecipe.Conditions[1].Data.Cast<HasPerkConditionData>().Perk.Link.FormKey = EnchantmentTiers[level].FormKey;
            patch.ConstructibleObjects.Add(tomeRecipe);
        }

        public static void PatchScroll(Scroll scroll, ISpellGetter spell)
        {
            var metadata = GetSpellMetadata(spell.HalfCostPerk);

            if (metadata is null)
            {
                Console.WriteLine($"Warning: {spell.FormKey.IDString()} in {spell.FormKey.ModKey} is missing a school of magic");
            }
            else
            {
                var (_, level) = metadata.Value;
                scroll.Name = scroll.Name?.String?.Replace("Scroll of", $"{level} Scroll of", StringComparison.OrdinalIgnoreCase);
                scroll.Keywords?.Add(Keywords.ScrollSchools[spell.HalfCostPerk]);
                scroll.Keywords?.Add(Keywords.ScrollTypes[spell.HalfCostPerk]);
            }
        }

        public static void PatchStaff(Weapon staff, ISpellGetter spell)
        {
            var metadata = GetSpellMetadata(spell.HalfCostPerk);

            if (metadata is null)
            {
                Console.WriteLine($"Warning: {spell.FormKey.IDString()} in {spell.FormKey.ModKey} is missing a school of magic");
            }
            else
            {
                var (_, level) = metadata.Value;
                staff.Name = staff.Name?.String?.Replace("Staff of", $"{level} Staff of", StringComparison.OrdinalIgnoreCase);
                staff.Keywords?.Add(Keywords.StaffSchools[spell.HalfCostPerk]);
                staff.Keywords?.Add(Keywords.StaffTypes[spell.HalfCostPerk]);
            }
        }
    }
}