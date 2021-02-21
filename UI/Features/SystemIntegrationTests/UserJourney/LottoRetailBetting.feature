Feature: Lotto Retail Betting


  @RULES_automation_todo @regression @acceptance
  Scenario: the player should be able to place a Lotto simple ticket (uid:d8f16b54-5140-4f6e-a74e-8f3256b5351c)
    Given the player has added "" Lotto selection to the Betslip
    When the player purchases an "AGENCY" Lotto "SIMPLE" ticket
    Then the "AGENCY" Lotto "SIMPLE" ticket is purchased
    And the data on the "DETAILS" is the same as data on the Betslip

  @RULES_automation_todo @regression @acceptance
  Scenario: the player should be able to place a Lotto system ticket (uid:1a284ab6-40f9-42ae-a49d-9ac977b09892)
    Given the player has added "1" Lotto selection to the Betslip
    When the player selects "RANDOM" combinations on the Betslip
    And the player purchases an "AGENCY" sport "SYSTEM" ticket
    Then the "AGENCY" sport "SYSTEM" ticket is purchased
    And the data on the "DETAILS" is the same as data on the Betslip
