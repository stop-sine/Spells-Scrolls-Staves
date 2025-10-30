using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Skyrim;

namespace SpellsScrollsStaves
{
    public class Patchers
    {
        private static readonly Dictionary<FormLink<IPerkGetter>, string> SpellLevels = new()
        {
                {Skyrim.Perk.AlterationNovice00, "Novice"},
                {Skyrim.Perk.ConjurationNovice00, "Novice"},
                {Skyrim.Perk.DestructionNovice00, "Novice"},
                {Skyrim.Perk.IllusionNovice00, "Novice"},
                {Skyrim.Perk.RestorationNovice00, "Novice"},
                {Skyrim.Perk.AlterationApprentice25, "Apprentice"},
                {Skyrim.Perk.ConjurationApprentice25, "Apprentice"},
                {Skyrim.Perk.DestructionApprentice25, "Apprentice"},
                {Skyrim.Perk.IllusionApprentice25, "Apprentice"},
                {Skyrim.Perk.RestorationApprentice25, "Apprentice"},
                {Skyrim.Perk.AlterationAdept50, "Adept"},
                {Skyrim.Perk.ConjurationAdept50, "Adept"},
                {Skyrim.Perk.DestructionAdept50, "Adept"},
                {Skyrim.Perk.IllusionAdept50, "Adept"},
                {Skyrim.Perk.RestorationAdept50, "Adept"},
                {Skyrim.Perk.AlterationExpert75, "Expert"},
                {Skyrim.Perk.ConjurationExpert75, "Expert"},
                {Skyrim.Perk.DestructionExpert75, "Expert"},
                {Skyrim.Perk.IllusionExpert75, "Expert"},
                {Skyrim.Perk.RestorationExpert75, "Expert"},
                {Skyrim.Perk.AlterationMaster100, "Master"},
                {Skyrim.Perk.ConjurationMaster100, "Master"},
                {Skyrim.Perk.DestructionMaster100, "Master"},
                {Skyrim.Perk.IllusionMaster100, "Master"},
                {Skyrim.Perk.RestorationMaster100, "Master"},
            };

        private static readonly Dictionary<FormLink<IPerkGetter>, string> SpellSchools = new()
        {
                {Skyrim.Perk.AlterationNovice00, "Alteration"},
                {Skyrim.Perk.ConjurationNovice00, "Conjuration"},
                {Skyrim.Perk.DestructionNovice00, "Destruction"},
                {Skyrim.Perk.IllusionNovice00, "Illusion"},
                {Skyrim.Perk.RestorationNovice00, "Restoration"},
                {Skyrim.Perk.AlterationApprentice25, "Alteration"},
                {Skyrim.Perk.ConjurationApprentice25, "Conjuration"},
                {Skyrim.Perk.DestructionApprentice25, "Destruction"},
                {Skyrim.Perk.IllusionApprentice25, "Illusion"},
                {Skyrim.Perk.RestorationApprentice25, "Restoration"},
                {Skyrim.Perk.AlterationAdept50, "Alteration"},
                {Skyrim.Perk.ConjurationAdept50, "Conjuration"},
                {Skyrim.Perk.DestructionAdept50, "Destruction"},
                {Skyrim.Perk.IllusionAdept50, "Illusion"},
                {Skyrim.Perk.RestorationAdept50, "Restoration"},
                {Skyrim.Perk.AlterationExpert75, "Alteration"},
                {Skyrim.Perk.ConjurationExpert75, "Conjuration"},
                {Skyrim.Perk.DestructionExpert75, "Destruction"},
                {Skyrim.Perk.IllusionExpert75, "Illusion"},
                {Skyrim.Perk.RestorationExpert75, "Restoration"},
                {Skyrim.Perk.AlterationMaster100, "Alteration"},
                {Skyrim.Perk.ConjurationMaster100, "Conjuration"},
                {Skyrim.Perk.DestructionMaster100, "Destruction"},
                {Skyrim.Perk.IllusionMaster100, "Illusion"},
                {Skyrim.Perk.RestorationMaster100, "Restoration"},
            };

        private static void PatchName(Book tome, ISpellGetter spell)
        {
            var level = SpellLevels[spell.HalfCostPerk.FormKey];
            if (level is null)
            {
                Console.WriteLine($"Warning: {spell.FormKey.IDString()} in {spell.FormKey.ModKey} is missing a school of magic");
                tome.Name = tome.Name?.String?.Replace("Spell Tome:", $"Spell Tome of", StringComparison.OrdinalIgnoreCase);
            }
            else
                tome.Name = tome.Name?.String?.Replace("Spell Tome:", $"{level} Tome of", StringComparison.OrdinalIgnoreCase);
        }

        private static void PatchName(Scroll scroll, ISpellGetter spell)
        {
            var level = SpellLevels[spell.HalfCostPerk.FormKey];
            if (level is null)
                Console.WriteLine(spell.FormKey);
            scroll.Name = scroll.Name?.String?.Replace("Scroll of", $"{level} Scroll of", StringComparison.OrdinalIgnoreCase);
        }

        private static void PatchKeywords(Scroll scroll, ISpellGetter spell)
        {
            var school = SpellSchools[spell.HalfCostPerk.FormKey];
            var level = SpellLevels[spell.HalfCostPerk.FormKey];
        }
    }
}