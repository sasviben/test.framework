Feature: Lotto Online Betting


  @RULES_automation_todo @regression @acceptance @smoke
  Scenario: the online player should be able to place a Lotto simple ticket (uid:f8960b9d-4115-4884-a602-15cc1557ac27)
    Given the player is logged in
    And the player has added "1" Lotto selection to the Betslip
    When the player purchases an "ONLINE" Lotto "SIMPLE" ticket
    Then the "ONLINE" Lotto "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the Betslip
    And the data on the "DETAILS" is the same as data on the Betslip
    And the player balance amount is subtracted by the ticket stake

  @RULES_automation_todo @regression @acceptance
  Scenario: the online player should be able to place a Lotto system ticket (uid:eb8455b6-a313-418e-86d4-3b2049b17168)
    Given the player is logged in
    And the player has added "1" random "LOTTO" "FOOTBALL" events to the Betslip
    When the player selects "RANDOM" combinations on the Betslip
    And the player purchases an "ONLINE" Lotto "SYSTEM" ticket
    Then the "ONLINE" Lotto "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the Betslip
    And the data on the "DETAILS" is the same as data on the Betslip
    And the player balance amount is subtracted by the ticket stake
