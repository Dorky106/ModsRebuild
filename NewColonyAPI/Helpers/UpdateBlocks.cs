using Pipliz;
using System;

namespace PhentrixGames.NewColonyAPI.Helpers
{
    public static class UpdateBlocks
    {
        public static ushort UpdateBlockAt(Vector3Int location, string basename)
        {
            string sides = "";
            if (World.TryGetTypeAt(location + Vector3Int.forward, out ushort tmp))
            {
                if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                    sides += "f";
            }
            if (World.TryGetTypeAt(location + Vector3Int.right, out tmp))
            {
                if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                    sides += "r";
            }
            if (World.TryGetTypeAt(location + Vector3Int.back, out tmp))
            {
                if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                    sides += "b";
            }
            if (World.TryGetTypeAt(location + Vector3Int.left, out tmp))
            {
                if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                    sides += "l";
            }
            if (World.TryGetTypeAt(location + Vector3Int.up, out tmp))
            {
                if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                    sides += "u";
            }
            if (World.TryGetTypeAt(location + Vector3Int.down, out tmp))
            {
                if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                    sides += "d";
            }
            return BlockUpdate(basename, sides);
        }

        public static ushort UpdateWindowBlockAt(Vector3Int location, string basename)
        {
            string modifier = "";
            string sides = "";
            ushort tmp;

            if (basename.EndsWith("RX"))
            {
                if (World.TryGetTypeAt(location + Vector3Int.back, out tmp))
                {
                    if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                    {
                        sides += "r";
                    }
                }
                if (World.TryGetTypeAt(location + Vector3Int.forward, out tmp))
                {
                    if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                    {
                        sides += "l";
                    }
                }
            }
            else if (basename.EndsWith("RZ"))
            {
                if (World.TryGetTypeAt(location + Vector3Int.right, out tmp))
                {
                    if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                    {
                        sides += "r";
                    }
                }
                if (World.TryGetTypeAt(location + Vector3Int.left, out tmp))
                {
                    if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                    {
                        sides += "l";
                    }
                }
            }
            else
            {
                throw new Exception("BaseName must end with either RX or RZ!");
            }

            if (World.TryGetTypeAt(location + Vector3Int.up, out tmp))
            {
                if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                    sides += "u";
            }
            if (World.TryGetTypeAt(location + Vector3Int.down, out tmp))
            {
                if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                    sides += "d";
            }

            if (basename.EndsWith("RZ"))
            {
                if (sides.Contains("u") && sides.Contains("r"))
                {
                    if (World.TryGetTypeAt(location + Vector3Int.up + Vector3Int.right, out tmp))
                    {
                        if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                            modifier += "TR";
                    }
                }
                if (sides.Contains("u") && sides.Contains("l"))
                {
                    if (World.TryGetTypeAt(location + Vector3Int.up + Vector3Int.left, out tmp))
                    {
                        if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                            modifier += "TL";
                    }
                }

                if (sides.Contains("d") && sides.Contains("r"))
                {
                    if (World.TryGetTypeAt(location + Vector3Int.down + Vector3Int.right, out tmp))
                    {
                        if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                            modifier += "BR";
                    }
                }
                if (sides.Contains("d") && sides.Contains("l"))
                {
                    if (World.TryGetTypeAt(location + Vector3Int.down + Vector3Int.left, out tmp))
                    {
                        if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                            modifier += "BL";
                    }
                }
            }
            else if (basename.EndsWith("RX"))
            {
                if (sides.Contains("u") && sides.Contains("r"))
                {
                    if (World.TryGetTypeAt(location + Vector3Int.up + Vector3Int.back, out tmp))
                    {
                        if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                            modifier += "TR";
                    }
                }
                if (sides.Contains("u") && sides.Contains("l"))
                {
                    if (World.TryGetTypeAt(location + Vector3Int.up + Vector3Int.forward, out tmp))
                    {
                        if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                            modifier += "TL";
                    }
                }

                if (sides.Contains("d") && sides.Contains("r"))
                {
                    if (World.TryGetTypeAt(location + Vector3Int.down + Vector3Int.back, out tmp))
                    {
                        if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                            modifier += "BR";
                    }
                }
                if (sides.Contains("d") && sides.Contains("l"))
                {
                    if (World.TryGetTypeAt(location + Vector3Int.down + Vector3Int.forward, out tmp))
                    {
                        if (ItemTypes.IndexLookup.GetName(tmp).Contains(basename))
                            modifier += "BL";
                    }
                }
            }

            return BlockUpdate(basename, sides, modifier);
        }

        private static ushort BlockUpdate(string basename, string sides, string modifier = "")
        {
            switch (sides)
            {
                case "frb":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusZ" + modifier);

                case "frbl":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XZ" + modifier);

                case "frblu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XZYPlus" + modifier);

                case "frblud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XZY" + modifier);

                case "frbld":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XZYMinus" + modifier);

                case "frbu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusZYPlus" + modifier);

                case "frbud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusZY" + modifier);

                case "frbd":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusZYMinus" + modifier);

                case "frl":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XZMinus" + modifier);

                case "frlu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XZMinusYPlus" + modifier);

                case "frlud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XZMinusY" + modifier);

                case "frld":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XZMinusYMinus" + modifier);

                case "fru":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusZMinusYPlus" + modifier);

                case "frud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusZMinusY" + modifier);

                case "frd":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusZMinusYMinus" + modifier);

                case "fr":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusZMinus" + modifier);

                case "fbl":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusZ" + modifier);

                case "fblu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusZYPlus" + modifier);

                case "fblud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusZY" + modifier);

                case "fbld":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusZYMinus" + modifier);

                case "fbu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "ZYPlus" + modifier);

                case "fbud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "ZY" + modifier);

                case "fbd":
                    return ItemTypes.IndexLookup.GetIndex(basename + "ZYMinus" + modifier);

                case "fb":
                    return ItemTypes.IndexLookup.GetIndex(basename + "Z" + modifier);

                case "flu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusZMinusYPlus" + modifier);

                case "flud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusZMinusY" + modifier);

                case "fld":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusZMinusYMinus" + modifier);

                case "fl":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusZMinus" + modifier);

                case "fud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "ZMinusY" + modifier);

                case "fu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "ZMinusYPlus" + modifier);

                case "fd":
                    return ItemTypes.IndexLookup.GetIndex(basename + "ZMinusYMinus" + modifier);

                case "f":
                    return ItemTypes.IndexLookup.GetIndex(basename + "ZMinus");

                case "rbl":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XZPlus" + modifier);

                case "rblu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XZPlusYPlus" + modifier);

                case "rblud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XZPlusY" + modifier);

                case "rbld":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XZPlusYMinus" + modifier);

                case "rbu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusZPlusYPlus" + modifier);

                case "rbud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusZPlusY" + modifier);

                case "rbd":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusZPlusYMinus" + modifier);

                case "rb":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusZPlus" + modifier);

                case "rlu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XYPlus" + modifier);

                case "rlud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XY" + modifier);

                case "rld":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XYMinus" + modifier);

                case "rl":
                    return ItemTypes.IndexLookup.GetIndex(basename + "X" + modifier);

                case "rud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusY" + modifier);

                case "ru":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusYPlus" + modifier);

                case "rd":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlusYMinus" + modifier);

                case "r":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XPlus");

                case "blu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusZPlusYPlus" + modifier);

                case "blud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusZPlusY" + modifier);

                case "bld":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusZPlusYMinus" + modifier);

                case "bl":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusZPlus" + modifier);

                case "bud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "ZPlusY" + modifier);

                case "bu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "ZPlusYPlus" + modifier);

                case "bd":
                    return ItemTypes.IndexLookup.GetIndex(basename + "ZPlusYMinus" + modifier);

                case "b":
                    return ItemTypes.IndexLookup.GetIndex(basename + "ZPlus");

                case "lud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusY" + modifier);

                case "lu":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusYPlus" + modifier);

                case "ld":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinusYMinus" + modifier);

                case "l":
                    return ItemTypes.IndexLookup.GetIndex(basename + "XMinus");

                case "ud":
                    return ItemTypes.IndexLookup.GetIndex(basename + "Y" + modifier);

                case "u":
                    return ItemTypes.IndexLookup.GetIndex(basename + "YPlus");

                case "d":
                    return ItemTypes.IndexLookup.GetIndex(basename + "YMinus");
            }
            return ItemTypes.IndexLookup.GetIndex(basename);
        }
    }
}