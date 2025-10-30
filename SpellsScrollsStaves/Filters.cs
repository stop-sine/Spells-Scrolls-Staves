using Noggog;
using Mutagen.Bethesda;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Skyrim;

namespace SpellsScrollsStaves
{
    public class Filters
    {
        private static bool SpellFilter(ISpellGetter spell)
        {
            if (spell.HalfCostPerk is null) return false;
            if (spell.EquipmentType.Equals(Skyrim.EquipType.LeftHand)) return false;
            if (spell.EquipmentType.Equals(Skyrim.EquipType.RightHand)) return false;
            return true;
        }

        private static bool TomeFilter(IBookGetter book)
        {
            if (book.Teaches is not BookSpell) return false;
            if (!book.Name?.String?.Contains("Spell Tome:", StringComparison.OrdinalIgnoreCase) ?? false) return false;
            return true;
        }

        private static bool ScrollFilter(IScrollGetter scroll)
        {
            if (!scroll.Name?.String?.Contains("Scroll") ?? false) return false;
            return true;
        }

        private static bool StaffFilter(IWeaponGetter weapon)
        {
            if (!weapon.Keywords?.Contains(Skyrim.Keyword.WeapTypeStaff) ?? false) return false;
            return true;
        }
    }
}