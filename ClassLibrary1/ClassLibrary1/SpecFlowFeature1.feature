﻿Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	Given I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
	Given I enter a name Jayman
	When I press getname
	Then my name is Jayman
	When dsfdsf fdgdfg fdg 
