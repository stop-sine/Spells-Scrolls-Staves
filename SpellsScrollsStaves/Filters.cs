using Noggog;
using Mutagen.Bethesda;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Skyrim;
using System.Diagnostics.CodeAnalysis;

namespace SpellsScrollsStaves
{
    public class Filters
    {
        /// <summary>
        /// Determines if a spell passes the filter criteria.
        /// </summary>
        /// <param name="spell">The spell to check.</param>
        /// <returns>True if the spell passes the filter; otherwise, false.</returns>
        public static bool SpellFilter([NotNull] ISpellGetter spell)
        {
            if (spell.HalfCostPerk is null) return false;
            if (spell.EquipmentType.Equals(Skyrim.EquipType.LeftHand)) return false;
            if (spell.EquipmentType.Equals(Skyrim.EquipType.RightHand)) return false;
            return true;
        }

        /// <summary>
        /// Determines if a book is a spell tome.
        /// </summary>
        /// <param name="book">The book to check.</param>
        /// <returns>True if the book is a spell tome; otherwise, false.</returns>
        public static bool TomeFilter([NotNull] IBookGetter book)
        {
            if (book.Teaches is not BookSpell) return false;
            if (!book.Name?.String?.Contains("Spell Tome:", StringComparison.OrdinalIgnoreCase) ?? false) return false;
            return true;
        }

        /// <summary>
        /// Determines if a scroll passes the filter criteria.
        /// </summary>
        /// <param name="scroll">The scroll to check.</param>
        /// <returns>True if the scroll passes the filter; otherwise, false.</returns>
        public static bool ScrollFilter([NotNull] IScrollGetter scroll)
        {
            if (scroll.Name?.String?.Contains("jzargo", StringComparison.OrdinalIgnoreCase) ?? false) return false;
            if (scroll.Name?.String?.Contains("Scroll") ?? false) return true;
            return false;
        }

        /// <summary>
        /// Determines if a weapon is a staff.
        /// </summary>
        /// <param name="weapon">The weapon to check.</param>
        /// <returns>True if the weapon is a staff; otherwise, false.</returns>
        public static bool StaffFilter([NotNull] IWeaponGetter weapon)
        {
            if (!weapon.Keywords?.Contains(Skyrim.Keyword.WeapTypeStaff) ?? false) return false;
            return true;
        }
    }
}