<?php //File fetcher
	function get_dir($d, $c){
		$dir = $d."/*".$c.".*"; // Example: download/gci/filename.us.gci or rel/filname.GZ2E01.gct
		$f = glob($dir);
		$f = array_combine($f, array_map('filectime', $f));
		arsort($f);
		echo key($f);
	}
?>
<!DOCTYPE html>
<html>
	<head>
		<link rel="icon" target="_blank" href="favicon.png">
		<title>TP Randomizer</title>
		<meta property="og:title" content="Twilight Princess Randomizer" />
		<meta property="og:url" content="https://rando.zeldatp.net/" />
		<meta property="og:image" content="https://rando.zeldatp.net/img/logo.png" />
		<meta property="og:description" content="The official Twilight Princess Randomizer website! From download to setup and even tools!" />
		<link rel="stylesheet" target="_blank" href="css/style.css">
		<script src="jquery-3.6.0.js"></script>
	</head>
	<body>
		<script>
			function tabControl(evt, cityName) {
				// Declare all variables
				var i, tabcontent, tablinks;

				// Get all elements with class="tabcontent" and hide them
				tabcontent = document.getElementsByClassName("tabcontent");
				for (i = 0; i < tabcontent.length; i++) {
					tabcontent[i].style.display = "none";
				}

				// Get all elements with class="tablinks" and remove the class "active"
				tablinks = document.getElementsByClassName("tablinks");
				for (i = 0; i < tablinks.length; i++) {
					tablinks[i].className = tablinks[i].className.replace(" active", "");
				}

				// Show the current tab, and add an "active" class to the button that opened the tab
				document.getElementById(cityName).style.display = "block";
				evt.currentTarget.className += " active";
				}
		</script>
		<img src="img/logo.png"/>
		<div id="IsIE">
			<b>Your web browser is obsolete.</b>
			<br />
			Update your browser for more security, and in order to see this website.
			<br />
			There are plenty of other browsers far more secure and modern, for example 
			<a target="_blank" href="https://www.google.com/chrome/" style="color: red;">Chrome</a>
			 or 
			<a target="_blank" href="https://www.mozilla.org/en-US/firefox/new/" style="color: red;">Firefox.</a>
		</div>
		<div id="IsNotIE">
			<div class="blackbg">
				<div class="tab">
					<button class="tablinks" onclick="tabControl(event, 'randomizationSettingsTab')">Randomization Settings</button>
					<button class="tablinks" onclick="tabControl(event, 'gameplaySettingsTab')">Gameplay Settings</button>
					<button class="tablinks" onclick="tabControl(event, 'excludedChecksTab')">Excluded Checks</button>
					<button class="tablinks" onclick="tabControl(event, 'startingInventoryTab')">Starting Inventory</button>
					<button class="tablinks" onclick="tabControl(event, 'cosmeticsAndQuirksTab')">Cosmetics and Quirks</button>
				</div>
				  
				  <!-- Tab content -->
				<div id="randomizationSettingsTab" class="tabcontent">
					<div class="leftColumn">
						<fieldset id="logicSettingsFieldset">
							<legend>Logic Settings</legend>
							<label for="logicRulesFieldset">Logic Rules:</label>
							<select name="Logic Rules Fieldset" id="logicRulesFieldset">
								<option value="0">Glitchless</option>
								<option value="1" disabled>G̶l̶i̶t̶c̶h̶e̶d̶</option>
								<option value="2" disabled>N̶o̶ ̶L̶o̶g̶i̶c̶</option>
							</select>
							<br/>
							<label for="gameRegionFieldset">Game Region:</label>
							<select name="Game Region Fieldset" id="gameRegionFieldset">
								<option value="0">NTSC (US)</option>
								<option value="1">PAL (EUR)</option>
								<option value="2">JP (JAP)</option>
								<option value="3" disabled>Wii NTSC 1.0 (US)</option>
								<option value="4" disabled>Wii NTSC 1.2 (US)</option>
								<option value="5" disabled>Wii PAL (EUR)</option>
								<option value="6" disabled>Wii JP (JAP)</option>
							</select>
							<br/>
							<label for="seedNumberFieldset">Seed Number:</label>
							<select name="Seed Number Fieldset" id="seedNumberFieldset">
								<option value="0">0</option>
								<option value="1">1</option>
								<option value="2">2</option>
								<option value="3">3</option>
								<option value="4">4</option>
								<option value="5">5</option>
								<option value="6">6</option>
								<option value="7">7</option>
								<option value="8">8</option>
								<option value="9">9</option>
							</select>
						</fieldset>
						<fieldset id="accessOptionsFieldset">
							<legend> Access Options</legend>
							<label for="castleRequirementsFieldset">Hyrule Castle Requirements:</label>
							<select name="Castle Requirements" id="castleRequirementsFieldset">
								<option value="0"> Open </option>
								<option value="1"> Fused Shadows </option>
								<option value="2"> Mirror Shards </option>
								<option value="3"> All Dungeons </option>
								<option value="4" selected>Vanilla</option>
							</select>
							<br/>
							<label for="palaceRequirementsFieldset">Palace of Twilight Requirements:</label>
							<select name="Palace Requirements" id="palaceRequirementsFieldset">
								<option value="0"> Open </option>
								<option value="1"> Fused Shadows </option>
								<option value="2"> Mirror Shards </option>
								<option value="3" selected> Vanilla </option>
							</select>
							<br/>
							<label for="faronLogicFieldset">Faron Woods Logic:</label>
							<select name="Faron Woods  Logic" id="faronLogicFieldset">
								<option value="0">Open</option>
								<option value="1" selected>Closed</option>
							</select>
							<br/>
							<input type="checkbox" id="mdhCheckbox" name="MDH Logic" value="">
							<label for="mdhCheckbox">  Skip Midna's Desperate Hour </label><br>
							<input type="checkbox" id="introCheckbox" name="Intro Logic" value="">
							<label for="introCheckbox"> Skip Prologue </label><br>
							<input type="checkbox" id="barrenCheckbox" name="Intro Logic" value="">
							<label for="introCheckbox"> Barren Unrequired Dungeons </label><br>
						</fieldset>
					</div>
					<fieldset id="itemPoolOptionsFieldset">
					<legend>Item Pool Options</legend>
						<fieldset id="dungeonItemOptionsFieldset">
						<legend>Dungeon Items</legend>
							<label for="smallKeyFieldset">Small Keys:</label>
							<select name="Small Keys" id="smallKeyFieldset">
								<option value="1">Vanilla</option>
								<option value="2">Own Dungeon</option>
								<option value="3">Any Dungeon</option>
								<option value="4">Keysanity</option>
								<option value="5">Keysey</option>
							</select>
							<br/>
							<label for="bigKeyFieldset">Big Keys:</label>
							<select name="Big Keys" id="bigKeyFieldset">
								<option value="0">Vanilla</option>
								<option value="1">Own Dungeon</option>
								<option value="2">Any Dungeon</option>
								<option value="3">Keysanity</option>
								<option value="4">Keysey</option>
							</select>
							<br/>
							<label for="mapAndCompassFieldset">Maps and Compasses:</label>
							<select name="Maps and Compasses" id="mapAndCompassFieldset">
								<option value="0">Vanilla</option>
								<option value="1">Own Dungeon</option>
								<option value="2">Any Dungeon</option>
								<option value="3">Anywhere</option>
								<option value="4">Start With</option>
							</select>
						</fieldset>
						<fieldset id="itemCategoriesFieldset">
						<legend>Item Categories</legend>
							<input type="checkbox" id="goldenBugsCheckbox" name="Golden Bugs" value="">
							<label for="goldenBugsCheckbox"> Golden Bugs </label><br>
							<input type="checkbox" id="skyCharacterCheckbox" name="Sky Characters" value="">
							<label for="skyCharacterCheckbox"> Sky Characters </label><br>
							<input type="checkbox" id="giftsFromNPCsCheckbox" name="Gifts From NPCs" value="">
							<label for="giftsFromNPCsCheckbox"> Gifts From NPCs </label><br>
							<input type="checkbox" id="poesCheckbox" name="Poes" value="">
							<label for="poesCheckbox"> Poes </label><br>
							<input type="checkbox" id="shopItemsCheckbox" name="Shop Items" value="">
							<label for="shopItemsCheckbox"> Shop Items </label><br>
							<input type="checkbox" id="hiddenSkillsCheckbox" name="Hidden Skills" value="">
							<label for="hiddenSkillsCheckbox"> Hidden Skills </label><br>
							<label for="foolishItemFieldset">Foolish Items:</label>
							<select name="Foolish Items" id="foolishItemFieldset">
								<option value="0">None</option>
								<option value="1">Few</option>
								<option value="2">Many</option>
								<option value="3">Mayhem</option>
								<option value="4">Nightmare</option>
							</select>
						</fieldset>
					</fieldset>
				</div>
				  
				<div id="gameplaySettingsTab" class="tabcontent">
					<div class="leftColumn">
						<fieldset id="clearedTwilightsFieldset">
							<legend>Cleared Twilights</legend>
							<input type="checkbox" id="faronTwilightCheckbox" name="Faron Twilight Checkbox" value="">
							<label for="faronTwilightCheckbox"> Faron Twilight Cleared </label><br>
							<input type="checkbox" id="eldinTwilightCheckbox" name="Eldin Twilight Checkbox" value="">
							<label for="eldinTwilightCheckbox"> Eldin Twilight Cleared </label><br>
							<input type="checkbox" id="lanayruTwilightCheckbox" name="Lanayru Twilight Checkbox" value="">
							<label for="lanayruTwilightCheckbox"> Lanayru Twilight Cleared </label><br>
						</fieldset>
						<fieldset id="cutscenesAndMundaneSkipsFieldset">
							<legend>Cutscenes/Mundane Skips</legend>
							<input type="checkbox" id="skipMinorCutscenesCheckbox" name="Skip Minor Cutscenes Checkbox" value="">
							<label for="skipMinorCutscenesCheckbox"> Skip Minor Cutscenes </label><br>
						</fieldset>
					</div>
					<fieldset id="dungeonRequirementsFieldset">
						<legend>Dungeon Logic Settings</legend>
						<input type="checkbox" id="minesEntranceCheckbox" name="Goron Mines Checkbox" value="">
						<label for="minesEntranceCheckbox"> Goron Mines Does Not Require Wrestling </label><br>
						<input type="checkbox" id="lakebedEntranceCheckbox" name="Lakebed Temple Checkbox" value="">
						<label for="lakebedEntranceCheckbox"> Lakebed Does Not Require Water Bombs </label><br>
						<input type="checkbox" id="arbitersEntranceCheckbox" name="Arbiters Grounds Checkbox" value="">
						<label for="arbitersEntranceCheckbox"> Arbiters Does Not Require Bulblin Camp </label><br>
						<input type="checkbox" id="snowpeakEntranceCheckbox" name="Snowpeak Ruins Checkbox" value="">
						<label for="snowpeakEntranceCheckbox"> Snowpeak Does Not Require Reekfish Scent </label><br>
						<input type="checkbox" id="totEntranceCheckbox" name="Temple of Time Checkbox" value="">
						<label for="totEntranceCheckbox"> Temple of Time Does Not Require Master Sword </label><br>
						<input type="checkbox" id="cityEntranceCheckbox" name="City in The Sky Checkbox" value="">
						<label for="cityEntranceCheckbox"> City in The Sky Does Not Require Skybook </label><br>
					</fieldset>
				</div>
				  
				<div id="excludedChecksTab" class="tabcontent">
					<fieldset id="checkboxFieldset">
					<legend>Excluded Checks</legend>
					<ul id="baseExcludedChecksListbox" multiple="multiple" size="10" width="20%">
						<?php 
							$files = glob('Generator/World/Checks/*/*/*.json');
								$i = 0;
							foreach ($files as $file) 
							{
								$file = preg_replace('/\\.[^.\\s]{3,4}$/', '', $file);
								echo "<li><label><input type = checkbox id='$i'>".pathinfo($file, PATHINFO_BASENAME)."</label> </li>"; 
								$i++;
							}
						?>
					</ul>
					</fieldset>	
				</div>

				<div id="startingInventoryTab" class="tabcontent">
				<fieldset id="checkboxFieldset">
					<legend>Starting Items</legend>
					<ul id="baseImportantItemsListbox" multiple="multiple" size="10" width="20%">
						<?php 
							$important_items = file_get_contents("Resources/StartingItems.txt");
							$important_items = explode("\n", $important_items);
							foreach ($important_items as $important_item) 
							{
								list($value, $name) = explode(",", $important_item);
								$name = str_replace("_"," ", $name);
								echo "<li><label><input type = checkbox id='$value'>".$name."</label> </li>"; 
							}
						?>
					</ul>
				</fieldset>
				</div>

				<div id="cosmeticsAndQuirksTab" class="tabcontent">
					<div class="leftColumn">
						<fieldset id="additionalSettingsFieldset">
							<legend>Additional Settings</legend>
							<input type="checkbox" id="fastIBCheckbox" name="Fast IB Checkbox" value="">
							<label for="fastIBCheckbox"> Fast Iron Boots </label><br>
							<input type="checkbox" id="quickTransformCheckbox" name="Quick Transform Checkbox" value="">
							<label for="quickTransformCheckbox"> Quick Transform </label><br>
							<input type="checkbox" id="transformAnywhereCheckbox" name="Transform Anywhere Checkbox" value="">
							<label for="transformAnywhereCheckbox">  Transform Anywhere </label><br>
							<input type="checkbox" id="increaseWalletCheckbox" name="Increase Wallet Checkbox" value="">
							<label for="increaseWalletCheckbox"> Increase Wallet Capacity</label><br>
							<input type="checkbox" id="modifyShopModelsCheckbox" name="Modify Shop Models Checkbox" value="">
							<label for="modifyShopModelsCheckbox">Shop Models Show The Replaced Item</label><br>
						</fieldset>
						<fieldset id="musicAndSFXFieldset">
							<legend> Music and SFX </legend>
							<input type="checkbox" id="randomizeBGMCheckbox" name="Randomize BGM Checkbox" value="">
							<label for="randomizeBGMCheckbox"> Randomize Background Music </label><br>
							<input type="checkbox" id="randomizeFanfaresCheckbox" name="Randomize Fanfares Checkbox" value="">
							<label for="randomizeFanfaresCheckbox"> Randomize Fanfares </label><br>
							<input type="checkbox" id="disableEnemyBGMCheckbox" name="Disable Enemy BGM Checkbox" value="">
							<label for="disableEnemyBGMCheckbox"> Disable Enemy Background Music</label><br>
						</fieldset>
					</div>
					<fieldset id="itemPoolOptionsFieldset">
					<legend>Item Pool Options</legend>
						<label for="tunicColorFieldset">Tunic Color: (not implemented)</label>
						<select name="Tunic Color Fieldset" id="tunicColorFieldset">
							<option value="0">Default</option>
							<option value="1">Red</option>
							<option value="2">Green</option>
							<option value="3">Blue</option>
							<option value="4">Yellow</option>
							<option value="5">Purple</option>
							<option value="6">Gray</option>
							<option value="7">Black</option>
							<option value="8">White</option>
						</select>
						<br/>
						<label for="lanternColorFieldset">Lantern Color:</label>
						<select name="Lantern Color Fieldset" id="lanternColorFieldset">
							<option value="0">Default</option>
							<option value="1">Red</option>
							<option value="2">Orange</option>
							<option value="3">Yellow</option>
							<option value="4">Green</option>
							<option value="5">Blue</option>
							<option value="6">Purple</option>
							<option value="7">White</option>
							<option value="8">Cyan</option>
						</select>
						<br/>
						<label for="midnaHairColorFieldset">Midna Hair Color: (not implemented)</label>
						<select name="Midna Hair Color Fieldset" id="midnaHairColorFieldset">
							<option value="0">Default</option>
							<option value="1">Blue</option>
						</select>
						<br/>
						<label for="heartColorFieldset">Heart Color:</label>
						<select name="Heart Color Fieldset" id="heartColorFieldset">
							<option value="0">Default</option>
							<option value="1">Pink</option>
							<option value="2">Orange</option>
							<option value="3">Green</option>
							<option value="4">Teal</option>
							<option value="5">Blue</option>
							<option value="6">Purple</option>
							<option value="7">Black</option>
							<option value="8">Rainbow</option>
						</select>
						<br/>
						<label for="aButtonColorFieldset">A Button Color:</label>
						<select name="A Button Color Fieldset" id="aButtonColorFieldset">
							<option value="0">Default</option>
							<option value="1">Red</option>
							<option value="2">Orange</option>
							<option value="3">Yellow</option>
							<option value="4">Dark Green</option>
							<option value="5">Blue</option>
							<option value="6">Purple</option>
							<option value="7">Black</option>
							<option value="8">Grey</option>
							<option value="9">Pink</option>
						</select>
						<br/>
						<label for="bButtonColorFieldset">B Button Color:</label>
						<select name="B Button Color Fieldset" id="bButtonColorFieldset">
							<option value="0">Default</option>
							<option value="1">Orange</option>
							<option value="2">Pink</option>
							<option value="3">Green</option>
							<option value="4">Blue</option>
							<option value="5">Purple</option>
							<option value="6">Black</option>
							<option value="7">Teal</option> 
						</select>
						<br/>
						<label for="xButtonColorFieldset">X Button Color:</label>
						<select name="X Button Color Fieldset" id="xButtonColorFieldset">
							<option value="0">Default</option>
							<option value="1">Red</option>
							<option value="2">Orange</option>
							<option value="3">Yellow</option>
							<option value="4">Lime Green</option>
							<option value="5">Dark Green</option>
							<option value="6">Blue</option>
							<option value="7">Purple</option>
							<option value="8">Black</option>
							<option value="9">Pink</option>
							<option value="10">Cyan</option>
						</select>
						<br/>
						<label for="yButtonColorFieldset">Y Button Color:</label>
						<select name="Y Button Color Fieldset" id="yButtonColorFieldset">
							<option value="0">Default</option>
							<option value="1">Red</option>
							<option value="2">Orange</option>
							<option value="3">Yellow</option>
							<option value="4">Lime Green</option>
							<option value="5">Dark Green</option>
							<option value="6">Blue</option>
							<option value="7">Purple</option>
							<option value="8">Black</option>
							<option value="9">Pink</option>
							<option value="10">Cyan</option>
						</select>
						<br/>
						<label for="zButtonColorFieldset">Z Button Color:</label>
						<select name="Z Button Color Fieldset" id="zButtonColorFieldset">
							<option value="0">Default</option>
							<option value="1">Red</option>
							<option value="2">Orange</option>
							<option value="3">Yellow</option>
							<option value="4">Lime Green</option>
							<option value="5">Dark Green</option>
							<option value="6">Purple</option>
							<option value="7">Black</option>
							<option value="8">Light Blue</option>
						</select>
					</fieldset>
				</div>
				<br/>
				<form method="post" action="generator.php">
				<label for="settingsStringTextbox">Settings String:</label>
  				<input type="text" id="settingsStringTextbox" name="settingsStringTextBox" style="min-width: 30em;">
				<input type="number" id="seed-slot" name="seed-slot" value="-1" hidden/>
				<input id="importSettingsStringButton" value="Import/Apply" type="button">
				<br/>
				<input id="generateSeedButton" name="generateSeedButton" value="Generate" type="submit" >
				</form>
                <script>
                    document.getElementById('seedNumberFieldset').addEventListener("change",
                    function ()
                    {
                        document.getElementById('seed-slot').value = this.value;
                    });
                    document.getElementById('seed-slot').value = 0;
                </script>
			</div>
			<div class="blackbg">
				<h1>Tools and resources</h1>
				<hr />
				<br />
				<table>
					<tr>
						<td class="rBor">
							<a target="_blank" href="https://takarikka.github.io/TP-Tracker/"><img src="img/github.png" alt=" Github Logo" /></a>
						</td>
						<td class="rBor">
							<a target="_blank" href="https://docs.google.com/spreadsheets/d/1quJjkAGV7asF1CNRtJEDNsy9Oga7hmzGLe09u2zxdJI/edit#gid=1131787935"><img src="img/sheets.png" alt="Google Sheets Logo"/></a>
						</td>
						<td class="rBor">
							<a target="_blank" href="http://tp.docs.aecx.cc/Yet+Another+GameCube+Documentation/index.html"><img src="img/yagcd.png" alt="YAGCD Logo"/></a>
						</td>
						<td class="rBor">
							<a target="_blank" href="https://github.com/zsrtp"><img src="img/tp.png" alt="Midna Icon"/></a>
						</td>
						<td class="rBor">
							<a target="_blank" href="https://wiki.zeldatp.net/Main_Page"><img src="img/wiki.png" alt="Wiki Logo"/></a>
						</td>
						<td>
							<a target="_blank" href="https://discord.zeldatp.net/"><img src="img/discord.png" alt="Discord Logo"/></a>
						</td>
					</tr>
					<tr>
						<td class="rBor">
							<a target="_blank" href="https://takarikka.github.io/TP-Tracker/">Taka's Item Tracker</a>
						</td>
						<td class="rBor">
							<a target="_blank" href="https://docs.google.com/spreadsheets/d/1quJjkAGV7asF1CNRtJEDNsy9Oga7hmzGLe09u2zxdJI/edit#gid=1131787935">Rando Dev Sheet</a>
						</td>
						<td class="rBor">
							<a target="_blank" href="http://tp.docs.aecx.cc/Yet+Another+GameCube+Documentation/index.html">YAGCD</a>
						</td>
						<td class="rBor">
							<a target="_blank" href="https://github.com/zsrtp">TP Devs</a>
						</td>
						<td class="rBor">
							<a target="_blank" href="https://wiki.zeldatp.net/Main_Page">TP Speedrun Wiki</a>
						</td>
						<td>
							<a target="_blank" href="https://discord.zeldatp.net/">Discord</a>
						</td>
					</tr>
				</table>
			</div>
			<div class="blackbg" style="padding: 0px; margin-bottom: 0px;">
				<p>
					v1.09 - Made with 
					<img style="display: inline; margin: 0px 0px -10px;" src="img/heart.png" alt="Heart Container"/>
					 by 
					<a target="_blank" href="https://github.com/zsrtp/Randomizer-Frontend" target="_blank" style="color: #d62013;">Luneyes</a>!<br/>
					
					Logo and background image are property of Nintendo. No infringement intended. We love you guys!<br/>
					
					Logo edited by <a target="_blank" href="https://twitter.com/MelonSpeedruns" target="_blank" style="color: #d62013;">MelonSpeedruns</a>!
					
				</p>
			</div>
		</div>
	</body>
	<script src="script.js"></script>
</html>
