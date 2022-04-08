namespace TPRandomizer.Assets
{
    using System.Collections.Generic;

    /// <summary>
        /// summary text.
        /// </summary>
    public class Flags
    {
        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly byte[,] FaronTwilightRegionFlags = new byte[,]
            {
                { 0x2, 0x46 }, // Midna jump 1 mist area.
                { 0x2, 0x47 }, // Midna jump 1 mist area.
                { 0x2, 0x5D }, // North Faron Portal.
                { 0x2, 0x98 }, // South Faron Portal.
                { 0x0, 0x6B }, // Ordon Spring Portal.
            };

        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly byte[,] EldinTwilightRegionFlags = new byte[,]
            {
                { 0x3, 0x14 }, // Collected Tear From Bomb Storage
                { 0x3, 0x1A }, // Collected Tear From Bomb Storage
                { 0x3, 0x1B }, // Collected Tear From Bomb Storage
                { 0x3, 0x40 }, // Kakariko Village Portal
                { 0x3, 0x4A }, // Death Mountain Portal
                { 0x3, 0xA7 }, // Unlock Jumps to top of Sanctuary
		{ 0x6, 0x4A }, // Give Gorge Portal
            };

        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly byte[,] BaseRandomizerRegionFlags = new byte[,]
            {
                { 0x0, 0x57 }, // Spider on Link's Ladder killed.
                { 0x16, 0x47 }, // West Bridge in CiTS Broken.
                { 0x16, 0x4D }, // West Bridge in CiTS Extended.
                { 0x16, 0x5D }, // West Bridge in CiTS Spinner Slot Closed.
                { 0x16, 0x6D }, // West Bridge in CiTS Extended.
                { 0x16, 0x6B }, // West Bridge in CiTS Destroyed CS Trigger.
                { 0x2, 0x63 }, // Trill lets you shop at his store.
                { 0x2, 0x60 }, // Got Lantern Back from Monkey
                { 0x6, 0x4C }, // Bridge of Eldin Warped back CS.
                { 0xA, 0x99 }, // Desert Entrance CS.
                { 0xA, 0x20 }, // Set Freestanding key flag.
                { 0x3, 0xA4 }, // Barnes Sells Bombs.
                { 0x6, 0x7E }, // Kakariko Gorge placed CS
                { 0x10, 0x49 }, // FT Ook Bridge Destroyed
            };

        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly byte[,] IntroRegionFlags = new byte[,]
            {
                { 0x0, 0x63 }, // Spawn the Chest in Link's House
                { 0x2, 0x4B }, // Unlock North Faron Woods Gate
            };
        
        public static readonly byte[,] CutsceneRegionFlags = new byte[,]
            {
                { 0x0, 0x4A }, // Ordon Day 3 Intro CS.
                { 0x0, 0x4C }, // Knocked down Ordon bee nest CS.
                { 0x0, 0x4E }, // Ordon Ranch first time CS.
                { 0x0, 0x53 }, // Ilia spring CS watched.
                { 0x0, 0x54 }, // Ilia spring CS started.
                { 0x0, 0x55 }, // Ordon Village first time CS.
                { 0x0, 0x56 }, // Ilia spring CS trigger.
                { 0x0, 0x68 }, // Approach Faron Twilgiht with Midna CS.
                { 0x0, 0x6E }, // Enter shield house as wolf CS.
                { 0x0, 0x75 }, // Midna text after hearing Bo and Jaggle talk about the shield.
                { 0x0, 0x7C }, // Midna text before jumping to Ordon Shop roof.
                { 0x0, 0x7D }, // Rusl talking to Uli during wolf night CS.
                { 0x0, 0xB8 }, // Enter Ordon Village as wolf CS.
                { 0x1, 0x42 }, // Midna text after first gate in sewers.
                { 0x1, 0x43 }, // Midna text after exiting to rooftops.
                { 0x1, 0x44 }, // Woke up in jail CS.
                { 0x1, 0x4B }, // Midna CS after digging out of jail.
                { 0x1, 0x4C }, // Midna intro CS.
                { 0x1, 0x51 }, // Zelda tower intro CS.
                { 0x1, 0x57 }, // Outside top door intro CS.
                { 0x1, 0x5A }, // Went to the otherside of the fence in sewers CS.
                { 0x1, 0x5B }, // Top of stairway intro CS.
                { 0x1, 0x5C }, // Stairway intro CS.
                { 0x1, 0x7B }, // Midna text when approaching the rooftop guard.
                { 0x1, 0x7F }, // Midna CS after digging out of jail. (Second flag)
                { 0x2, 0x74 }, // Faron intro CS.
                { 0x2, 0x77 }, // See Faron Light Spirit from afar CS.
                { 0x2, 0x7C }, // Entered mist area as human.
                { 0x2, 0x95 }, // Midna text after warping to North Faron for bridge.
                { 0x3, 0x49 }, // Death mountain intro CS.
                { 0x3, 0x83 }, // Kakariko Graveyard intro CS.
                { 0x3, 0x8C }, // Midna text after Meteor fell.
                { 0x3, 0x9A }, // Kakariko Village intro CS.
            };

        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly Dictionary<int, byte[,]> RegionFlags = new ()
        {
            { 0, IntroRegionFlags },
            { 1, FaronTwilightRegionFlags },
            { 2, EldinTwilightRegionFlags },
            { 3, CutsceneRegionFlags },
        };

        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly byte[,] BaseRandomizerEventFlags = new byte[,]
        {
            { 0x6, 0x9 }, // Tame Epona, KB1 trigger activated
            { 0x14, 0x10 }, // Put Bo outside, ready to wrestle
            { 0xA, 0x2F }, // Bridge of Eldin Stolen, KB1 defeated, KB1 started
            { 0xF, 0x8 }, // Bridge of Eldin Warped Back
            { 0x40, 0x8 }, // Visited Gerudo Desert for the first time.
            { 0x7, 0xA0 }, // Watched Colin CS after KB1, talked to Bo before sumo
            { 0x20, 0x20 }, // Master Sword Story Progression
            { 0x20, 0x10 }, // Arbiters Grounds Story Progression
            { 0x2C, 0x10 }, // Raised the mirror in the Mirror Chamber
            { 0x1B, 0x38 }, // Skip Monkey Escort
            { 0x6, 0x20 }, // Warped Kakariko Bridge Back.
            { 0x5F, 0x20 }, // Shad leaves sanctuary.
        };

        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly byte[,] FaronTwilightEventFlags = new byte[,]
        {
            { 0x5, 0x7F }, // Midna Charge Unlocked, Finished Sewers, Midna text after entering Faron Twilight, Met Zelda in sewers, Midna cut prison chain, Watched Sewers intro CS, Escaped cell in sewers.
            { 0x6, 0x10 }, // Cleared Faron Twilight
            { 0xC, 0x18 }, // Midna accompanies Wolf, sword and shield removed from wolf's back.
            { 0x3, 0x2 }, // Gave Wooden Sword to Talo
            { 0x43, 0x8 }, // Senses unlocked
        };

        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly byte[,] EldinTwilightEventFlags = new byte[,]
        {
            { 0x7, 0x8 }, // Cleared Eldin Twilight
            { 0x6, 0x4 }, // Map Warping unlocked.
        };

        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly byte[,] IntroEventFlags = new byte[,]
        {
            { 0x4, 0x4 }, // Talked to Uli Day 1.
            { 0x45, 0x10 }, // Saved Talo
            { 0x10, 0x1 }, // Cat got Fish
            { 0x3, 0x2 }, // Gave Wooden Sword to Talo
            { 0x4A, 0x60 }, // Completed Ordon Day 1 and Finished Sword Training.
            { 0x16, 0x1 }, // Completed Ordon Day 2.
            { 0x15, 0x80 }, // Watched CS for Goats 2 Done.
            { 0x46, 0x10 }, // Rode Epona back to Link's House
            { 0x12, 0x8 }, // Can use Sera's Shop.
        };

        public static readonly byte[,] CutsceneEventFlags = new byte[,]
        {
            { 0x1, 0x40 }, // Talked to Yeto First Time.
            { 0x3, 0x90 }, // Jaggle Calls out to Link, talked to Squirrel as Wolf in Ordon.
            { 0x5, 0x10 }, // Unchain Wolf Link.
            { 0x6, 0xC0 }, // CS After beating Ordon Shadow, CS after entering Faron Twilight.
            { 0x10, 0x2 }, // Talked to Jaggle after climbing vines.
            { 0xF, 0x40 }, // Talked to Doctor for the first time.
            { 0x5E, 0x10 }, // Midna text after beating Forest Temple.
            { 0x1D, 0x40 }, // Listened to Fyer at drained lake.
            { 0x22, 0x1 }, // Plumm initial CS watched.
            { 0x26, 0x2 }, // Talked to Yeto on Snowpeak.
            { 0x28, 0x40 }, // Used Ooccoo for the first time.
            { 0x37, 0x4 }, // Postman twilight text.
            { 0x38, 0x6 }, // Hena cabin first time CS, talked to Hena first time.
            { 0x3A, 0x1 }, // Talked to Ralis in Graveyard for the first time.
            { 0x40, 0x2 }, // Agreed to help Rusl after Snowpeak Ruins.
            { 0x42, 0x1 }, // Watched post-ToT Ooccoo CS.
            { 0x45, 0x8 }, // Allows postman letters to show up in inventory.
            { 0x4A, 0x10 }, // Saw Talo in cage CS.
            { 0x3E, 0x2 }, // City Ooccoo CS watched.
            { 0x59, 0x40 }, // Met Postman for the first time.
            { 0x5D, 0x40 }, // Midna text after Kargarok flight.
        };

        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly Dictionary<int, byte[,]> EventFlags = new ()
        {
            { 0, IntroEventFlags },
            { 1, FaronTwilightEventFlags },
            { 2, EldinTwilightEventFlags },
            { 3, CutsceneEventFlags },
        };
        private static readonly RandomizerSetting RandomizerSettings = Randomizer.RandoSetting;
        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly bool[] FlagSettings = new bool[]
        {
            RandomizerSettings.introSkipped,
            RandomizerSettings.faronTwilightCleared,
            RandomizerSettings.eldinTwilightCleared,
            RandomizerSettings.skipMinorCutscenes,
        };
    }
}