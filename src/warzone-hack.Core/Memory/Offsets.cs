namespace WzHack.Core.Memory;

/// <summary>Structure offsets for Call of Duty Warzone — update after each game patch.</summary>
public static class Offsets
{
    /// <summary>Module-level addresses (relative to module base).</summary>
    public static class Client
    {
        public const nint LocalPlayer        = 0x1636D1B;
        public const nint EntityList         = 0x1941FD6;
        public const nint ViewMatrix         = 0x1AC884D;
        public const nint GameRules          = 0x1989000;
        public const nint GlobalVars         = 0x186424F;
        public const nint InputSystem        = 0x1AB28F1;
    }

    /// <summary>Entity / pawn struct field offsets.</summary>
    public static class Entity
    {
        public const nint Health             = 0x31B;
        public const nint TeamNum            = 0x3A3;
        public const nint Origin             = 0x17D6;
        public const nint EyeAngles          = 0x15D4;
        public const nint SceneNode          = 0x34D;
        public const nint ModelState         = 0x13C;
        public const nint ShotsFired         = 0x2000;
        public const nint AimPunch           = 0x1830;
        public const nint IsScoped           = 0x234F;
        public const nint CrosshairId        = 0x1896;
        public const nint Flags              = 0x1F1;
        public const nint Velocity           = 0x14AB;
        public const nint FlashDuration      = 0x1593;
        public const nint SpottedMask        = 0x16E6;
        public const nint BoneMatrix         = 0xB69;
    }

    /// <summary>Bone indices for skeleton rendering and aim targeting.</summary>
    public static class Bones
    {
        public const int Head               = 6;
        public const int Neck               = 5;
        public const int SpineUpper         = 4;
        public const int SpineMid           = 3;
        public const int Pelvis             = 0;
        public const int LeftShoulder       = 8;
        public const int LeftElbow          = 9;
        public const int LeftHand           = 13;
        public const int RightShoulder      = 30;
        public const int RightElbow         = 31;
        public const int RightHand          = 35;
        public const int LeftKnee           = 22;
        public const int LeftFoot           = 24;
        public const int RightKnee          = 44;
        public const int RightFoot          = 46;
    }
}
