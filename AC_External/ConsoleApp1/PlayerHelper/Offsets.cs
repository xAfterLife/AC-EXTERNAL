namespace AC_External
{
    public static unsafe class Offsets
    {
        #region CONST
        public const int BaseAddress = 0x400000;
        public const int baseGame = 0x0050F4E8;
        public const int ptrCurrentWeapon = 0x0378;
        public const int EntityList = 0x10F4F8;
        public const int LocalPlayer = 0x10F4F4;
        public const int headPos = 0x0004;
        public const int footPos = 0x0034;                  //X
        public const int m_XPos = 0x0038;                   //Y
        public const int m_YPos = 0x003C;                   //Z
        public const int m_ZPos = 0x0040;
        public const int yaw = 0x0040;
        public const int pitch = 0x0044;
        public const int m_isPosMoving = 0x0070;
        public const int m_Speed = 0x0080;
        public const int m_Health = 0x00F8;
        public const int m_Vest = 0x00FC;
        public const int m_AmmoMags = 0x0128;
        public const int m_Ammo = 0x0150;
        public const int m_SecAmmo = 0x013C;
        public const int m_Flashbangs = 0x0158;
        public const int m_WeaponTimer = 0x0178;
        public const int m_ShotsFired = 0x01A0;
        public const int sv_GetMode = 0x50F49C;
        public const int sv_ClientNumber = 0x510198;
        public const int sv_name = 0x51019C;
        public const int p_MaxRoll = 0x510144;
        public const int p_AutoReload = 0x5101D0;
        public const int o_Paused = 0x510CE0;
        public const int o_GameSpeed = 0x510CDC;
        public const int m_MouseShotSensitivity = 0x4EE444;                 //CHANGE THIS TO 0 FOR NO RECOIL 
        public const int m_InvertMouse = 0x51016C;
        public const int h_ToggleConsole = 0x4FEC10;
        public const int h_ShowTarget = 0x50F284;
        public const int h_ShowSpeed = 0x50F288;
        public const int h_ShowScoreOnDeath = 0x50F514;
        public const int h_ShowRadarValues = 0x50F268;
        public const int h_ShowMap = 0x50F240;
        public const int h_Righthanded = 0x510A4C;
        public const int h_RadarHeight = 0x50F264;
        public const int h_RadarEntSize = 0x50F208;
        public const int h_OldAmmoHUD = 0x510A48;
        public const int h_HideRadar = 0x50F21C;
        public const int h_HideHudMessages = 0x50F230;
        public const int h_HideHudEquipment = 0x50F234;
        public const int h_HideDamageIndicator = 0x50F248;
        public const int h_HideCompass = 0x50F220;
        public const int h_DrawGun = 0x50F200;
        public const int h_DrawFPS = 0x50F210;
        public const int h_DbgPos = 0x50F280;
        public const int h_DamageScreenFade = 0x50F278;
        public const int h_DamageScreenFactor = 0x50F270;
        public const int h_DamageScreenAlpha = 0x50F274;
        public const int h_DamageScreen = 0x50F26C;
        public const int h_CrosshairSize = 0x50F20C;
        public const int g_GameVersion = 0x510CF4;
        public const int dbg_FlySpeed = 0x510148;
        public const int EngineState_Test = 0x509BD8;
        #endregion
    }
}
