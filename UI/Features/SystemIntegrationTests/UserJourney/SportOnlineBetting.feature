Feature: Sport Online Betting


  @RULES_automated @regression @acceptance
  Scenario: the online player should be able to purchase a Prematch simple ticket (uid:1358b00e-c0ce-4fd9-8fa0-0c496626f5c6)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player purchases an "ONLINE" sport "SIMPLE" ticket
    Then the "ONLINE" sport "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the ticket stake

  @RULES_automated @regression @acceptance
  Scenario: the online player should be able to purchase a Inplay simple ticket (uid:6da48565-61fc-407a-8f86-5435fa3edc4a)
    Given the player is logged in
    And the player has added "1" random "INPLAY" "FOOTBALL" events to the Betslip
    When the player purchases an "ONLINE" sport "SIMPLE" ticket
    Then the "ONLINE" sport "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the ticket stake
