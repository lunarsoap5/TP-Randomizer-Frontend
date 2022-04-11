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
        public static readonly byte[,] LanayruTwilightRegionFlags = new byte[,]
            {
                { 0x6, 0x58 }, // Lake Hylia has water on Hyrule Field Map
                { 0x6, 0x5C }, // Castle Town Portal
                { 0x4, 0x7F }, // Lake Hylia has water on Lake Hylia Map.
                { 0x4, 0x55 }, // Lake Hylia Portal.
                { 0x4, 0x5D }, // Zora's Domain Portal.
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
                { 0x4, 0x58 }, // Talked to Rutella in Lanayru Twilight.
                { 0x4, 0x5F }, // Zora's domain intro CS twilight. 
                { 0x4, 0x67 }, // Midna text after jumping to Lake from burning bridge.
                { 0x4, 0x6B }, // Zora's Domain exit flood water cutscene.
                { 0x4, 0x72 }, // Midna text after arriving at frozen Upper Zora River.
                { 0x4, 0x91 }, // Midna text after frozen Zora Domain intro CS.
                { 0x4, 0xB0 }, // Watched CS of Ooccoo running to Sky Cannon.
                { 0x6, 0x68 }, // Midna text after warping Gorge bridge.
                { 0x6, 0x7C }, // Midna text after Lanayru Field twilight CS.
                { 0x6, 0x72 }, // Faron Field intro CS.
                { 0x6, 0x40 }, // Twilight Lanayru Field intro CS.
                { 0x6, 0x4F }, // Cutscene of gate outside Kakariko Village.
                { 0x6, 0xB3 }, // Midna text after entering Lanayru Twilight.
                { 0x6, 0xB6 }, // Midna text after entering Eldin Twilight.
                { 0x6, 0xB7 }, // Midna text when seeing Eldin Twilight from far away.
                { 0x7, 0x42 }, // Midna text after pushing block shortcut as human after Grove 2.
                { 0x7, 0x43 }, // CS after pushing block shortcut as human after Grove 2.
                { 0x7, 0x44 }, // Lost Woods intro CS.
                { 0x8, 0x45 }, // Snowpeak Summit intro CS.
                { 0x8, 0x5E }, // Midna text outside SPR.
                { 0x8, 0x5F }, // Snowpeak intro CS.
                { 0x9, 0x55 }, // STAR Tent intro CS.
                { 0x9, 0x7D }, // Jovani House intro CS.
                { 0xA, 0x53 }, // Mirror Chamber Intro CS.
                { 0x10, 0x41 }, // Midna text after getting Boomerang.
                { 0x10, 0x42 }, // Midna text after Ook breaks the bridge.
                { 0x10, 0x47 }, // Midna text after freeing first monkey.
                { 0x10, 0x49 }, // Bridge before Ook broken.
                { 0x10, 0x56 }, // Bokoblins spot Link in windless bridge room.
                { 0x10, 0x57 }, // Turned bridge in windless bridge room.
                { 0x10, 0x72 }, // West Tile Worm room intro CS.
                { 0x10, 0x76 }, // Second monkey room intro CS.
                { 0x10, 0x7C }, // Big Baba room intro CS.
                { 0x10, 0x7D }, // Midna text in room before boss room.
                { 0x10, 0x7E }, // Midna text after saving monkey after defeating Ook.
                { 0x10, 0x85 }, // Midna text after opening hanging chest.
                { 0x10, 0x83 }, // East outside room intro CS. 
                { 0x10, 0xB6 }, // Forest Temple intro CS.
                { 0x11, 0x43 }, // Cut rope of door in outside room CS.
                { 0x11, 0x44 }, // Pressed second button of the main magnet room of the second floor CS trigger.
                { 0x11, 0x45 }, // Pressed third button in entrance room CS.
                { 0x11, 0x46 }, // Pressed second button in entrance room CS.
                { 0x11, 0x47 }, // Cut rope of door in Toadpoli room CS.
                { 0x11, 0x4A }, // Pressed first button of the main magnet room on the second floor CS.
                { 0x11, 0x68 }, // Pressed outside magnet switch for first time CS.
                { 0x11, 0x72 }, // Main magnet room intro CS.
                { 0x11, 0x73 }, // Main magnet room intro CS trigger.
                { 0x11, 0x7A }, // Outside room intro CS.
                { 0x11, 0x80 }, // Room after Bow chest intro CS.
                { 0x11, 0x81 }, // Pulled Beamos in outside room CS.
                { 0x11, 0x84 }, // Open gate in Toadpoli room CS.
                { 0x11, 0x85 }, // Pressed second button in Toadpoli room CS.
                { 0x11, 0x88 }, // Magnet maze room intro CS.
                { 0x11, 0x8A }, // Goron Mines intro CS.
                { 0x11, 0x8B }, // Pressed first button in entrance room CS.
                { 0x11, 0x8C }, // Open gate in entrance room CS.
                { 0x11, 0xBC }, // Main magnet room second floor intro CS.
                { 0x11, 0xBD }, // Main magnet room second floor intro CS trigger.
                { 0x11, 0xBE }, // Hit crystal switch in room after bow chest CS.
                { 0x11, 0xBF }, // Room after Bow chest intro CS trigger.
                { 0x12, 0x46 }, // Midna Stalactite text in second room.
                { 0x12, 0x7E }, // Horizontal wheel is turning in east room CS.
                { 0x12, 0x7F }, // Horizontal wheel is turning in east room CS trigger.
                { 0x12, 0xA5 }, // Central room intro CS.
                { 0x12, 0xA6 }, // South bridge to main room intro CS.
                { 0x12, 0xA7 }, // Lakebed Temple intro CS.
                { 0x12, 0xAA }, // Rotate staircase main room CS.
                { 0x12, 0xB4 }, // East water supply Chu Worm CS.
                { 0x13, 0x5A }, // Turn walls in third room Basement second floor CS.
                { 0x13, 0x73 }, // Arbiters Grounds intro CS.
                { 0x13, 0x94 }, // Risen tracks on pilar before boss CS.
                { 0x14, 0x83 }, // First Floor Northwest room intro CS.
                { 0x14, 0xA1 }, // Midna text after finding Bedroom Key.
                { 0x14, 0xA7 }, // Snowpeak Ruins intro CS.
                { 0x14, 0xAA }, // Freezard in cage CS.
                { 0x14, 0xAC }, // Courtyard intro CS.
                { 0x14, 0xAE }, // Pumpkin room intro CS.
                { 0x14, 0xB2 }, // Midna text after getting Cheese.
                { 0x14, 0xB4 }, // Midna text after getting Pumpkin.
                { 0x15, 0x40 }, // Midna text telling you to use your senses on the missing statue.
                { 0x15, 0x41 }, // Midna text after using senses on missing statue.
                { 0x15, 0x4A }, // Temple of Time intro CS.
                { 0x15, 0x4B }, // Scales of Time room intro CS.
                { 0x15, 0x4C }, // CS after changing the balance on the scales for the first time.
                { 0x15, 0x4D }, // CS trigger after changing the balance on the scales for the first time.
                { 0x15, 0x90 }, // Pressed button in room 1 for the first time CS.
                { 0x15, 0x91 }, // Pressed the button on the seventh floor for the first time CS.
                { 0x15, 0x94 }, // Pressed the button on the fifth floor for the first time CS.
                { 0x15, 0x95 }, // Pressed buttons on third floor for the first time CS.
                { 0x15, 0x96 }, // Pressed the button on the second floor for the first time CS.
                { 0x16, 0x64 }, // North wing main room intro CS.
                { 0x16, 0x65 }, // East wing fan room second floor intro CS.
                { 0x16, 0x66 }, // Went beyond first gate outside shop intro CS.
                { 0x16, 0x67 }, // City in The Sky intro CS.
                { 0x16, 0x6E }, // East bridge extended CS.
                { 0x17, 0x4D }, // Phantom Zant 1 CS.
                { 0x17, 0x5E }, // Palace of Twilight intro CS.
                { 0x17, 0x66 }, // Midna text when west hand steals sol.
                { 0x17, 0x6F }, // Midna text about black fog in west room.
                { 0x17, 0x70 }, // Midna text after finding west sol.
                { 0x17, 0x72 }, // Midna text trigger when seeing a Twili for the first time.
                { 0x17, 0x78 }, // Midna text when seeing a Twili for the first time.
                { 0x17, 0x79 }, // Midna text after Light Sword cutscene.
                { 0x17, 0x95 }, // Midna text after re-entering west wing after sol was stolen.
                { 0x17, 0x9E }, // Midna text at dungeon entrance.
                { 0x17, 0xB3 }, // Watched east wing second room stairs CS.
                { 0x18, 0x4F }, // Hyrule Castle Graveyard intro CS.
                { 0x18, 0x8C }, // East garden intro CS.
                { 0x18, 0x8D }, // East garden intro CS trigger.
                { 0x18, 0x77 }, // Midna text at the east end of the east garden.
                { 0x18, 0x82 }, // South garden intro CS.
                { 0x18, 0x86 }, // Midna text after KB4.
                { 0x18, 0x99 }, // Double Darknut room intro CS
                { 0x18, 0xA4 }, // Midna text after Owl Statue chest in graveyard.
                { 0x18, 0xA6 }, // Trigger for Midna text after KB4.
                { 0x18, 0xB7 }, // Lit southeast torch in second floor north room for the first time CS.
                { 0x18, 0xB8 }, // Lit northeast torch in second floor north room for the first time CS.
            };

        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly Dictionary<int, byte[,]> RegionFlags = new ()
        {
            { 0, IntroRegionFlags },
            { 1, FaronTwilightRegionFlags },
            { 2, EldinTwilightRegionFlags },
            { 3, LanayruTwilightRegionFlags },
            { 4, CutsceneRegionFlags },
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
            { 0xF7, 0x1 }, // Add 256 Rupees to Charlo.
            { 0xF8, 0xF4 }, // Add 244 Rupees to Charlo.
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
        public static readonly byte[,] LanayruTwilightEventFlags = new byte[,]
        {
            { 0x8, 0x80 }, // Zora's Domain Thawed.
            { 0xC, 0x2 }, // Lanayru Twilight Story Flag.
            { 0xA, 0x10 }, // Defeated Kargarok Rider at Lake (allows player to howl for Kargorok.);
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
        public static readonly byte[,] OpenForestEventFlags = new byte[,]
        {
            { 0x6, 0x2 }, // Forest Temple Story Flag
        };

        /// <summary>
        /// summary text.
        /// </summary>
        public static readonly Dictionary<int, byte[,]> EventFlags = new ()
        {
            { 0, IntroEventFlags },
            { 1, FaronTwilightEventFlags },
            { 2, EldinTwilightEventFlags },
            { 3, LanayruTwilightEventFlags },
            { 4, CutsceneEventFlags },
            { 5, OpenForestEventFlags },
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
            RandomizerSettings.lanayruTwilightCleared,
            RandomizerSettings.skipMinorCutscenes,
            RandomizerSettings.faronWoodsLogic == "Open"
        };
    }
}