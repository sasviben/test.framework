Feature: Sport Retail Betting


  @RULES_automation_todo @regression @acceptance @smoke
  Scenario: the player should be able to purchase a Prematch simple ticket (uid:85527a0b-49ee-4ec6-aa85-d4fe709980e3)
    Given the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player purchases an "AGENCY" sport "SIMPLE" ticket
    Then the "AGENCY" sport "SIMPLE" ticket is purchased

  @RULES_automation_todo @regression @acceptance
  Scenario: the player should be able to purchase a Prematch system ticket (uid:ce19e99a-8ac9-4754-b50f-a09d29929dd5)
    Given the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player selects "1/3,3/3" combinations on the Betslip
    And the player purchases an "AGENCY" sport "SYSTEM" ticket
    Then the "AGENCY" sport "SIMPLE" ticket is purchased

  @RULES_automation_todo @regression
  Scenario: the player should see the same data on the purchased mix simple ticket (Prematch and Inplay) as on the Betslip (uid:75539c07-f40a-4dbb-aec1-04916528828d)
    Given the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    When the player purchases an "AGENCY" sport "SIMPLE" ticket
    Then the "AGENCY" sport "SIMPLE" ticket is purchased
    And the data on the "DETAILS" is the same as data on the Betslip

  @RULES_automation_todo @regression
  Scenario: the player should see the same data on the purchased mix system ticket (Prematch and Inplay) as on the Betslip (uid:f635f301-1b16-4797-bc0a-95488466e643)
    Given the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    When the player selects "1/4,4/4" combinations on the Betslip
    And the player purchases an "AGENCY" sport "SYSTEM" ticket
    Then the "AGENCY" sport "SYSTEM" ticket is purchased
    And the data on the "DETAILS" is the same as data on the Betslip

  @RULES_automation_todo @regression @acceptance
  Scenario: the player should be able to purchase a mix Prematch and Special simple ticket (uid:f6dea336-be0b-4bab-a8fb-f98d1806fce9)
    Given the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    When the player purchases an "AGENCY" sport "SIMPLE" ticket
    Then the "AGENCY" sport "SIMPLE" ticket is purchased

  @RULES_automation_todo @regression @acceptance
  Scenario: the player should be able to purchase a mix Prematch and Special system ticket (uid:9ae84377-0788-44b9-a71d-1a4f92946d3d)
    Given the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    When the player selects "1/4,4/4" combinations on the Betslip
    And the player purchases an "AGENCY" sport "SYSTEM" ticket
    Then the "AGENCY" sport "SYSTEM" ticket is purchased
