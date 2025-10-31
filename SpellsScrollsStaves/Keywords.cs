using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace SpellsScrollsStaves
{
    public class Keywords
    {
        public static readonly Dictionary<string, IFormLinkGetter<IKeywordGetter>> TomeSchools = new() {
            {"Alteration", FormKey.Factory("00084E:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Conjuration", FormKey.Factory("00084F:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Destruction", FormKey.Factory("000850:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Illusion", FormKey.Factory("000851:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Restoration", FormKey.Factory("000852:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()}
        };

        public static readonly Dictionary<string, IFormLinkGetter<IKeywordGetter>> TomeLevels = new() {
            {"Novice", FormKey.Factory("000853:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Apprentice", FormKey.Factory("000854:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Adept", FormKey.Factory("000855:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Expert", FormKey.Factory("000856:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Master", FormKey.Factory("000857:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()}
        };

        public static readonly Dictionary<(string, string), IFormLinkGetter<IKeywordGetter>> TomeTypes = new() {
            {("Novice", "Alteration"), FormKey.Factory("000858:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Alteration"), FormKey.Factory("000859:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Alteration"), FormKey.Factory("00085A:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Alteration"), FormKey.Factory("00085B:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Alteration"), FormKey.Factory("00085C:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},

            {("Novice", "Conjuration"), FormKey.Factory("00085D:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Conjuration"), FormKey.Factory("00085E:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Conjuration"), FormKey.Factory("00085F:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Conjuration"), FormKey.Factory("000860:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Conjuration"), FormKey.Factory("000861:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},

            {("Novice", "Destruction"), FormKey.Factory("000862:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Destruction"), FormKey.Factory("000863:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Destruction"), FormKey.Factory("000864:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Destruction"), FormKey.Factory("000865:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Destruction"), FormKey.Factory("000866:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},

            {("Novice", "Illusion"), FormKey.Factory("000867:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Illusion"), FormKey.Factory("000868:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Illusion"), FormKey.Factory("000869:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Illusion"), FormKey.Factory("00086A:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Illusion"), FormKey.Factory("00086B:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},

            {("Novice", "Restoration"), FormKey.Factory("00086C:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Restoration"), FormKey.Factory("00086D:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Restoration"), FormKey.Factory("00086E:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Restoration"), FormKey.Factory("00086F:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Restoration"), FormKey.Factory("000870:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
        };

        public static readonly Dictionary<string, IFormLinkGetter<IKeywordGetter>> ScrollSchools = new() {
            {"Alteration", FormKey.Factory("00082B:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Conjuration", FormKey.Factory("00082C:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Destruction", FormKey.Factory("00082D:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Illusion", FormKey.Factory("00082E:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Restoration", FormKey.Factory("000882F:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()}
        };

        public static readonly Dictionary<(string, string), IFormLinkGetter<IKeywordGetter>> ScrollTypes = new() {
            {("Novice", "Alteration"), FormKey.Factory("000812:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Alteration"), FormKey.Factory("000813:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Alteration"), FormKey.Factory("000814:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Alteration"), FormKey.Factory("000815:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Alteration"), FormKey.Factory("000816:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},

            {("Novice", "Conjuration"), FormKey.Factory("000817:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Conjuration"), FormKey.Factory("000818:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Conjuration"), FormKey.Factory("000819:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Conjuration"), FormKey.Factory("00081A:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Conjuration"), FormKey.Factory("00081B:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},

            {("Novice", "Destruction"), FormKey.Factory("00081C:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Destruction"), FormKey.Factory("00081D:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Destruction"), FormKey.Factory("00081E:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Destruction"), FormKey.Factory("00081F:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Destruction"), FormKey.Factory("000820:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},

            {("Novice", "Illusion"), FormKey.Factory("000821:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Illusion"), FormKey.Factory("000822:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Illusion"), FormKey.Factory("000823:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Illusion"), FormKey.Factory("000824:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Illusion"), FormKey.Factory("000825:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},

            {("Novice", "Restoration"), FormKey.Factory("000826:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Restoration"), FormKey.Factory("000827:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Restoration"), FormKey.Factory("000828:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Restoration"), FormKey.Factory("000829:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Restoration"), FormKey.Factory("00082A:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
        };

        public static readonly Dictionary<string, IFormLinkGetter<IKeywordGetter>> StaffSchools = new() {
            {"Alteration", FormKey.Factory("000849:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Conjuration", FormKey.Factory("00084A:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Destruction", FormKey.Factory("00084B:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Illusion", FormKey.Factory("00084C:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {"Restoration", FormKey.Factory("000884D:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()}
        };

        public static readonly Dictionary<(string, string), IFormLinkGetter<IKeywordGetter>> StaffTypes = new() {
            {("Novice", "Alteration"), FormKey.Factory("000830:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Alteration"), FormKey.Factory("000831:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Alteration"), FormKey.Factory("000832:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Alteration"), FormKey.Factory("000833:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Alteration"), FormKey.Factory("000834:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},

            {("Novice", "Conjuration"), FormKey.Factory("000835:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Conjuration"), FormKey.Factory("000836:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Conjuration"), FormKey.Factory("000837:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Conjuration"), FormKey.Factory("000838:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Conjuration"), FormKey.Factory("000839:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},

            {("Novice", "Destruction"), FormKey.Factory("00083A:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Destruction"), FormKey.Factory("00083B:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Destruction"), FormKey.Factory("00083C:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Destruction"), FormKey.Factory("00083D:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Destruction"), FormKey.Factory("00083E:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},

            {("Novice", "Illusion"), FormKey.Factory("00083F:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Illusion"), FormKey.Factory("000840:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Illusion"), FormKey.Factory("000841:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Illusion"), FormKey.Factory("000842:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Illusion"), FormKey.Factory("000843:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},

            {("Novice", "Restoration"), FormKey.Factory("000844:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Apprentice", "Restoration"), FormKey.Factory("000845:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Adept", "Restoration"), FormKey.Factory("000846:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Expert", "Restoration"), FormKey.Factory("000847:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
            {("Master", "Restoration"), FormKey.Factory("000848:Spells Scrolls Staves - TnE - TEMPLATE.esp").ToLinkGetter<IKeywordGetter>()},
        };
    }
}