Feature: Smart3d Features

A short summary of the feature

 
Scenario: First Test Case
	Given I am on welcome page and i press take me to demo mode
	Then  I press ok on Demo mode popup
	And I press no thanks on welcome popup
	When I am on All-Around page and i validate the program card is "All-Around"
	And  I press split sourruounding volume on All-Around program
	Then I validate "Right HI" volume is '9'
	And I validate "Left HI" volume is '9'
	When I set "Right HI" sourrounding volume to "3" of All-Around program 
	And I set "Left HI" sourrounding volume to "10" of All-Around program 
	Then I validate "Right HI" volume is '3'
	And I validate "Left HI" volume is '10'
	When  I press merge sourrounding voulume on All-Around program
	Then I validate "HI" volume is '3'
	When I set "HI" sourrounding volume to "13" of All-Around program
	Then I validate "HI" volume is '13'
	When I press 'Speech Clarity' quick button on All-Around Program
	Then validate 'Speech Clarity' quick button is enabled on All-Around Program
	When I press 'Noise filter' quick button on All-Around Program
	Then validate 'Noise filter' quick button is enabled on All-Around Program
	And  validate 'Speech clarity' quick button is disabled on All-Around program
	When I press 'Speech clarity' quick button on All-Around Program
	Then validate 'Speech clarity' quick button is enabled on All-Around Program
	And validate 'Noise filter' quick button is disabled on All-Around program
	When I press Sound Enhancer button on 'All Around' program
	And I set 'Bass gain' to '4' on All-Around Sound Enhancer
	And I set 'Middle gain' to '-3' on All-Around Sound Enhancer
	And I set 'Treble gain' to '5' on All-Around Sound Enhancer
	Then I validate "Bass gain" is "4" on All-Around Sound Enhancer
	And  I validate "Middle gain" is "-3" on All-Around Sound Enhancer
	And I validate "Treble gain" is "5" on All-Around Sound Enhancer
	When I press Tinnitus Manager on 'All Around' Sound Enhancer
	And I press Nature sounds button "Calming waves" on All-Around Tinnitus Manager
	And I press Nature sounds button "Breaking Waves" on All-Around Tinnitus Manager
	When I press the exit button on 'All Around' Sound Enhancer
	When I swipe left to 'Hear in noise' program from current program
	Then I validate program card is "Hear in noise"
	When I press Sound Enhancer button on 'Hear in noise' program
    And I press Tinnitus Manager on 'Hear in noise' Sound Enhancer
	When I press white noise button Slight variation on Hear in noise Tinnitus Manager
	When I press Reset button on All-Around Tinnitus Manager
	When I press the exit button on 'Hear in noise' Sound Enhancer
	When I swipe left to 'Outdoor' program from current program
	Then I validate program card is "Outdoor"
	When I press Sound Enhancer button on 'Outdoor' program
	And I drag Wind Noise Reduction to Strong on Outdoor Sound Enhancer
	When I press the exit button on 'Outdoor' Sound Enhancer
	And I swipe left to 'Music' program from current program
	Then I validate program card is "Music"
	When I press 'Music' program on the top ribbon bar
	Then I validate program card is "Music"
	When I press 'Outdoor' program on the top ribbon bar
	Then I validate program card is "Outdoor"
	When I press 'Hear in noise' program on the top ribbon bar
	Then I validate program card is "Hear in noise"
	When I press 'All-Around' program on the top ribbon bar
	Then I validate program card is "All-Around"
	When I press Program overview button on topribbonbar
	And I press 'Hear in noise' program on Program overview
	When I press 'Outdoor' program on Program overview
	When I press 'Music' program on Program overview
	When I press 'All-Around' program on Program overview
	When I press the Close button on Program overview
	When I press menu item 'My ReSound' on bottom ribbon bar
    And I press 'Learn about the app' on My ReSound
	When I press Volume control on Learn about the app
	And I swipe left to '2 / 3' page on Learn about the app
	Then validate 'Left and right volume' animation is shown on Volume control
	When I swipe left to '3 / 3' page on Learn about the app
    Then  validate 'Mute' animation is shown on Volume control
	When I close on Learn about the app and back to My Resound page
	And I press 'Guiding tips' on My ReSound
	When I press 'OK' on Please notice dialog
	Then validate title is 'Guiding tips' on Guiding tips page
	When I press 'Noise filter' on Guiding tips
	And I press 'Got it' on 'Noise filter' nudging dialog
	And I press 'My Resound' on bottom ribbon bar and back to Guiding tips on My Resound
	And I press 'Music program' on Guiding tips
	Then validate 'Got it' button enabled on Music program nudging dialog
	Then validate 'Back to tips' button enabled on Music program nudging dialog
	When I press 'Got it' on 'Music program' nudging dialog
	And I press menu item 'More' on bottom ribbon bar
	Then validate Auto-activate favorite locations switch is 'on'
	When I press 'Auto-activate favorite locations' switch on More menu
	Then validate Auto-activate favorite locations switch is 'off'
	When I press 'Auto-activate favorite locations' switch on More menu
	Then validate Auto-activate favorite locations switch is 'on'
	When I press more menu item 'About'
	Then validate page title is displayed on 'About' page
	And validate html view is displayed on 'About' page
	When I press 'back' from 'About' page
	And I press more menu item 'Legal information'
	When I press Legal information item 'MANUFACTURER'
	Then I validate page title is displayed on 'Manufacturer' page
	When I press 'back' from 'Manufacturer' page
	And I press Legal information item 'TERMS AND CONDITIONS'
	Then I validate page title is displayed on 'Terms and Conditions' page
	When I press 'back' from 'Terms and Conditions' page
	And I press Legal information item 'PRIVACY POLICY'
	Then I validate page title is displayed on 'PRIVACY POLICY' page
	Then validate html view is displayed on 'PRIVACY POLICY' page
	When I press 'back' from 'PRIVACY POLICY' page 
	And I press 'back' from 'Legal information' page
	And I press more menu item 'Support'
	Then I validate page title is displayed on 'Support' page
	And validate html view is displayed on 'Support' page
	When I press 'back' from 'Support' page
	And I press menu item 'Home' on bottom ribbon bar