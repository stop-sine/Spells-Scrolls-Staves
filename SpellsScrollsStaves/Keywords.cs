using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;

namespace SpellsScrollsStaves
{
    public class Keywords
    {
        private const string TemplateEsp = "Spells Scrolls Staves - TnE - TEMPLATE.esp";

        // Define perk metadata once
        private static readonly Dictionary<IFormLinkGetter<IPerkGetter>, (string School, string Level)> PerkMetadata = new()
        {
            // Alteration
            {Skyrim.Perk.AlterationNovice00, ("Alteration", "Novice")},
            {Skyrim.Perk.AlterationApprentice25, ("Alteration", "Apprentice")},
            {Skyrim.Perk.AlterationAdept50, ("Alteration", "Adept")},
            {Skyrim.Perk.AlterationExpert75, ("Alteration", "Expert")},
            {Skyrim.Perk.AlterationMaster100, ("Alteration", "Master")},
            
            // Conjuration
            {Skyrim.Perk.ConjurationNovice00, ("Conjuration", "Novice")},
            {Skyrim.Perk.ConjurationApprentice25, ("Conjuration", "Apprentice")},
            {Skyrim.Perk.ConjurationAdept50, ("Conjuration", "Adept")},
            {Skyrim.Perk.ConjurationExpert75, ("Conjuration", "Expert")},
            {Skyrim.Perk.ConjurationMaster100, ("Conjuration", "Master")},
            
            // Destruction
            {Skyrim.Perk.DestructionNovice00, ("Destruction", "Novice")},
            {Skyrim.Perk.DestructionApprentice25, ("Destruction", "Apprentice")},
            {Skyrim.Perk.DestructionAdept50, ("Destruction", "Adept")},
            {Skyrim.Perk.DestructionExpert75, ("Destruction", "Expert")},
            {Skyrim.Perk.DestructionMaster100, ("Destruction", "Master")},
            
            // Illusion
            {Skyrim.Perk.IllusionNovice00, ("Illusion", "Novice")},
            {Skyrim.Perk.IllusionApprentice25, ("Illusion", "Apprentice")},
            {Skyrim.Perk.IllusionAdept50, ("Illusion", "Adept")},
            {Skyrim.Perk.IllusionExpert75, ("Illusion", "Expert")},
            {Skyrim.Perk.IllusionMaster100, ("Illusion", "Master")},
            
            // Restoration
            {Skyrim.Perk.RestorationNovice00, ("Restoration", "Novice")},
            {Skyrim.Perk.RestorationApprentice25, ("Restoration", "Apprentice")},
            {Skyrim.Perk.RestorationAdept50, ("Restoration", "Adept")},
            {Skyrim.Perk.RestorationExpert75, ("Restoration", "Expert")},
            {Skyrim.Perk.RestorationMaster100, ("Restoration", "Master")}
        };

        // FormKey ranges for each category
        private static class FormKeys
        {
            // Tome Schools: 084E-0852 (one per school)
            public static readonly Dictionary<string, string> TomeSchools = new()
            {
                {"Alteration", "00084E"},
                {"Conjuration", "00084F"},
                {"Destruction", "000850"},
                {"Illusion", "000851"},
                {"Restoration", "000852"}
            };

            // Tome Levels: 0853-0857 (one per level)
            public static readonly Dictionary<string, string> TomeLevels = new()
            {
                {"Novice", "000853"},
                {"Apprentice", "000854"},
                {"Adept", "000855"},
                {"Expert", "000856"},
                {"Master", "000857"}
            };

            // Tome Types: 0858-0870 (5 schools × 5 levels)
            public const int TomeTypesBase = 0x858;

            // Scroll Schools: 082B-082F (one per school)
            public static readonly Dictionary<string, string> ScrollSchools = new()
            {
                {"Alteration", "00082B"},
                {"Conjuration", "00082C"},
                {"Destruction", "00082D"},
                {"Illusion", "00082E"},
                {"Restoration", "00082F"}
            };

            // Scroll Types: 0812-082A (5 schools × 5 levels)
            public const int ScrollTypesBase = 0x812;

            // Staff Schools: 0849-084D (one per school)
            public static readonly Dictionary<string, string> StaffSchools = new()
            {
                {"Alteration", "000849"},
                {"Conjuration", "00084A"},
                {"Destruction", "00084B"},
                {"Illusion", "00084C"},
                {"Restoration", "00084D"}
            };

            // Staff Types: 0830-0848 (5 schools × 5 levels)
            public const int StaffTypesBase = 0x830;
        }

        private static readonly string[] SchoolOrder = ["Alteration", "Conjuration", "Destruction", "Illusion", "Restoration"];
        private static readonly string[] LevelOrder = ["Novice", "Apprentice", "Adept", "Expert", "Master"];

        private static int GetTypeIndex(string school, string level)
        {
            int schoolIndex = Array.IndexOf(SchoolOrder, school);
            int levelIndex = Array.IndexOf(LevelOrder, level);
            return schoolIndex * 5 + levelIndex;
        }

        private static IFormLinkGetter<IKeywordGetter> CreateKeywordLink(string formKeyStr)
        {
            return FormKey.Factory($"{formKeyStr}:{TemplateEsp}").ToLinkGetter<IKeywordGetter>();
        }

        // Public dictionaries built dynamically
        public static readonly Dictionary<IFormLinkGetter<IPerkGetter>, IFormLinkGetter<IKeywordGetter>> TomeSchools =
            PerkMetadata.ToDictionary(
                kvp => kvp.Key,
                kvp => CreateKeywordLink(FormKeys.TomeSchools[kvp.Value.School]));

        public static readonly Dictionary<IFormLinkGetter<IPerkGetter>, IFormLinkGetter<IKeywordGetter>> TomeLevels =
            PerkMetadata.ToDictionary(
                kvp => kvp.Key,
                kvp => CreateKeywordLink(FormKeys.TomeLevels[kvp.Value.Level]));

        public static readonly Dictionary<IFormLinkGetter<IPerkGetter>, IFormLinkGetter<IKeywordGetter>> TomeTypes =
            PerkMetadata.ToDictionary(
                kvp => kvp.Key,
                kvp => CreateKeywordLink($"{FormKeys.TomeTypesBase + GetTypeIndex(kvp.Value.School, kvp.Value.Level):X6}"));

        public static readonly Dictionary<IFormLinkGetter<IPerkGetter>, IFormLinkGetter<IKeywordGetter>> ScrollSchools =
            PerkMetadata.ToDictionary(
                kvp => kvp.Key,
                kvp => CreateKeywordLink(FormKeys.ScrollSchools[kvp.Value.School]));

        public static readonly Dictionary<IFormLinkGetter<IPerkGetter>, IFormLinkGetter<IKeywordGetter>> ScrollTypes =
            PerkMetadata.ToDictionary(
                kvp => kvp.Key,
                kvp => CreateKeywordLink($"{FormKeys.ScrollTypesBase + GetTypeIndex(kvp.Value.School, kvp.Value.Level):X6}"));

        public static readonly Dictionary<IFormLinkGetter<IPerkGetter>, IFormLinkGetter<IKeywordGetter>> StaffSchools =
            PerkMetadata.ToDictionary(
                kvp => kvp.Key,
                kvp => CreateKeywordLink(FormKeys.StaffSchools[kvp.Value.School]));

        public static readonly Dictionary<IFormLinkGetter<IPerkGetter>, IFormLinkGetter<IKeywordGetter>> StaffTypes =
            PerkMetadata.ToDictionary(
                kvp => kvp.Key,
                kvp => CreateKeywordLink($"{FormKeys.StaffTypesBase + GetTypeIndex(kvp.Value.School, kvp.Value.Level):X6}"));
    }
}