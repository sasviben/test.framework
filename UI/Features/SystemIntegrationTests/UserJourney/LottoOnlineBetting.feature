Feature: Lotto Online Betting


  @RULES_automation_todo @regression
  Scenario: the online player should see the same data on the purchased simple lotto ticket as on the Betslip (uid:f8960b9d-4115-4884-a602-15cc1557ac27)
    Given the player is logged in
    And the player has added "1" Lotto selection to the Betslip
    When the player purchases an "ONLINE" Lotto "SIMPLE" ticket
    Then the "ONLINE" Lotto "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the Betslip
    And the data on the "DETAILS" is the same as data on the Betslip
    And the player balance amount is subtracted by the ticket stake

  @RULES_automation_todo @regression
  Scenario: the online player should see the same data on the purchased system lotto ticket as on the Betslip (uid:eb8455b6-a313-418e-86d4-3b2049b17168)
    Given the player is logged in
    And the player has added "1" Lotto selection to the Betslip
    When the player selects "RANDOM" combinations on the Betslip
    And the player purchases an "ONLINE" Lotto "SYSTEM" ticket
    Then the "ONLINE" Lotto "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the Betslip
    And the data on the "DETAILS" is the same as data on the Betslip
    And the player balance amount is subtracted by the ticket stake

  @RULES_automated @regression @acceptance @smoke
  Scenario: the online player should be able to purchase a Lotto simple ticket (uid:b0afcf6e-f620-49a3-9e30-5dddc7895f39)
    Given the player is logged in
    And the player has added "1" Lotto selection to the Betslip
    When the player purchases an "ONLINE" Lotto "SIMPLE" ticket
    Then the "ONLINE" Lotto "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the ticket stake

  @RULES_automation_todo @regression @acceptance
  Scenario: the online player should be able to purchase a Lotto system ticket (uid:09583a25-4bb6-4ef8-8290-27899d29d103)
    Given the player is logged in
    And the player has added "5" Lotto selection to the Betslip
    And the player selects "2" combinations on the Betslip
    When the player purchases an "ONLINE" Lotto "SYSTEM" ticket
    Then the "ONLINE" Lotto "SYSTEM" ticket is purchased
    And the player balance amount is subtracted by the ticket stake
