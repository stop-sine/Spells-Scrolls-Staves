using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Skyrim;

namespace SpellsScrollsStaves
{
    public class Patchers
    {
        private static readonly Dictionary<IFormLinkGetter<IPerkGetter>, string> SpellLevels = new()
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

        private static readonly Dictionary<IFormLinkGetter<IPerkGetter>, string> SpellSchools = new()
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

        private static readonly Dictionary<IFormLinkGetter<IPerkGetter>, FormLink<IKeywordGetter>> TomeSchools = new()
        {
            {Skyrim.Perk.AlterationNovice00, FormKey.Factory("00084E:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.AlterationApprentice25, FormKey.Factory("00084E:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.AlterationAdept50, FormKey.Factory("00084E:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.AlterationExpert75, FormKey.Factory("00084E:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.AlterationMaster100, FormKey.Factory("00084E:Spells Scrolls Staves - TnE - TEMPLATE.esp")},

            {Skyrim.Perk.ConjurationNovice00, FormKey.Factory("00084F:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationApprentice25, FormKey.Factory("00084F:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationAdept50, FormKey.Factory("00084F:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationExpert75, FormKey.Factory("00084F:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationMaster100, FormKey.Factory("00084F:Spells Scrolls Staves - TnE - TEMPLATE.esp")},

            {Skyrim.Perk.DestructionNovice00, FormKey.Factory("000850:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionApprentice25, FormKey.Factory("000850:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionAdept50, FormKey.Factory("000850:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionExpert75, FormKey.Factory("000850:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionMaster100, FormKey.Factory("000850:Spells Scrolls Staves - TnE - TEMPLATE.esp")},

            {Skyrim.Perk.IllusionNovice00, FormKey.Factory("000851:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionApprentice25, FormKey.Factory("000851:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionAdept50, FormKey.Factory("000851:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionExpert75, FormKey.Factory("000851:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionMaster100, FormKey.Factory("000851:Spells Scrolls Staves - TnE - TEMPLATE.esp")},

            {Skyrim.Perk.RestorationNovice00, FormKey.Factory("000852:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationApprentice25, FormKey.Factory("000852:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationAdept50, FormKey.Factory("000852:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationExpert75, FormKey.Factory("000852:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationMaster100, FormKey.Factory("000852:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
        };

        private static readonly Dictionary<IFormLinkGetter<IPerkGetter>, FormLink<IKeywordGetter>> TomeTiers = new()
        {
            {Skyrim.Perk.AlterationNovice00, FormKey.Factory("000853:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationNovice00, FormKey.Factory("000853:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionNovice00, FormKey.Factory("000853:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionNovice00, FormKey.Factory("000853:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationNovice00, FormKey.Factory("000853:Spells Scrolls Staves - TnE - TEMPLATE.esp")},

            {Skyrim.Perk.AlterationApprentice25, FormKey.Factory("000854:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationApprentice25, FormKey.Factory("000854:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionApprentice25, FormKey.Factory("000854:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionApprentice25, FormKey.Factory("000854:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationApprentice25, FormKey.Factory("000854:Spells Scrolls Staves - TnE - TEMPLATE.esp")},

            {Skyrim.Perk.AlterationAdept50, FormKey.Factory("000855:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationAdept50, FormKey.Factory("000855:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionAdept50, FormKey.Factory("000855:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionAdept50, FormKey.Factory("000855:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationAdept50, FormKey.Factory("000855:Spells Scrolls Staves - TnE - TEMPLATE.esp")},

            {Skyrim.Perk.AlterationExpert75, FormKey.Factory("000856:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationExpert75, FormKey.Factory("000856:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionExpert75, FormKey.Factory("000856:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionExpert75, FormKey.Factory("000856:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationExpert75, FormKey.Factory("000856:Spells Scrolls Staves - TnE - TEMPLATE.esp")},

            {Skyrim.Perk.AlterationMaster100, FormKey.Factory("000857:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationMaster100, FormKey.Factory("000857:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionMaster100, FormKey.Factory("000857:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionMaster100, FormKey.Factory("000857:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationMaster100, FormKey.Factory("000857:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
        };

        private static readonly Dictionary<IFormLinkGetter<IPerkGetter>, FormLink<IKeywordGetter>> TomeTypes = new()
        {
            {Skyrim.Perk.AlterationNovice00, FormKey.Factory("000858:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.AlterationApprentice25, FormKey.Factory("000859:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.AlterationAdept50, FormKey.Factory("00085A:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.AlterationExpert75, FormKey.Factory("00085B:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.AlterationMaster100, FormKey.Factory("00085C:Spells Scrolls Staves - TnE - TEMPLATE.esp")},

            {Skyrim.Perk.ConjurationNovice00, FormKey.Factory("00085D:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationApprentice25, FormKey.Factory("00085E:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationAdept50, FormKey.Factory("00085F:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationExpert75, FormKey.Factory("000860:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.ConjurationMaster100, FormKey.Factory("000861:Spells Scrolls Staves - TnE - TEMPLATE.esp")},

            {Skyrim.Perk.DestructionNovice00, FormKey.Factory("000862:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionApprentice25, FormKey.Factory("000863:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionAdept50, FormKey.Factory("000864:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionExpert75, FormKey.Factory("000865:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.DestructionMaster100, FormKey.Factory("000866:Spells Scrolls Staves - TnE - TEMPLATE.esp")},

            {Skyrim.Perk.IllusionNovice00, FormKey.Factory("000867:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionApprentice25, FormKey.Factory("000868:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionAdept50, FormKey.Factory("000869:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionExpert75, FormKey.Factory("00086A:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.IllusionMaster100, FormKey.Factory("00086B:Spells Scrolls Staves - TnE - TEMPLATE.esp")},

            {Skyrim.Perk.RestorationNovice00, FormKey.Factory("00086C:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationApprentice25, FormKey.Factory("00086D:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationAdept50, FormKey.Factory("00086E:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationExpert75, FormKey.Factory("00086F:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
            {Skyrim.Perk.RestorationMaster100, FormKey.Factory("000870:Spells Scrolls Staves - TnE - TEMPLATE.esp")},
        };

        public static void PatchName(Book tome, ISpellGetter spell)
        {
            var level = SpellLevels[spell.HalfCostPerk];
            if (level is null)
            {
                Console.WriteLine($"Warning: {spell.FormKey.IDString()} in {spell.FormKey.ModKey} is missing a school of magic");
                tome.Name = tome.Name?.String?.Replace("Spell Tome:", $"Spell Tome of", StringComparison.OrdinalIgnoreCase);
            }
            else
                tome.Name = tome.Name?.String?.Replace("Spell Tome:", $"{level} Tome of", StringComparison.OrdinalIgnoreCase);
        }

        public static void PatchName(Scroll scroll, ISpellGetter spell)
        {
            var level = SpellLevels[spell.HalfCostPerk];
            if (level is null)
                Console.WriteLine(spell.FormKey);
            scroll.Name = scroll.Name?.String?.Replace("Scroll of", $"{level} Scroll of", StringComparison.OrdinalIgnoreCase);
        }

        public static void PatchKeywords(Book tome, ISpellGetter spell)
        {

        }

        public static void PatchKeywords(Scroll scroll, ISpellGetter spell)
        {
            //var school = SpellSchools[spell.HalfCostPerk.FormKey];
            //var level = SpellLevels[spell.HalfCostPerk.FormKey];
        }
    }
}