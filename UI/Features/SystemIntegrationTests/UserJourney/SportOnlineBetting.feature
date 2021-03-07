Feature: Sport Online Betting


  @RULES_automation_todo @regression
  Scenario: the online player should see the same data on the purchased mix simple ticket (Prematch and Inplay) as on the Betslip (uid:34b47b8a-f6f0-47f2-8fc7-e273e3e44508)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "INPLAY" "FOOTBALL" events to the Betslip
    When the player purchases an "ONLINE" sport "SIMPLE" ticket
    Then the "ONLINE" sport "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the Betslip
    And the data on the "DETAILS" is the same as data on the Betslip

  @RULES_automation_todo @regression
  Scenario: the online player should see the same data on the purchased mix system ticket (Prematch and Inplay) as on the Betslip (uid:8fd1e660-04d9-4065-8ec6-475471c91032)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "INPLAY" "FOOTBALL" events to the Betslip
    When the player selects "1/4,4/4" combinations on the Betslip
    And the player purchases an "ONLINE" sport "SYSTEM" ticket
    Then the "ONLINE" sport "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the Betslip
    And the data on the "DETAILS" is the same as data on the Betslip

  @RULES_automation_todo @regression
  Scenario: the online player should see the same data on the purchased mix simple ticket (Prematch and Special) as on the Betslip (uid:30cdb3a4-1470-440e-a1e5-d92fb5db8d14)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    When the player purchases an "ONLINE" sport "SIMPLE" ticket
    Then the "ONLINE" sport "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the Betslip
    And the data on the "DETAILS" is the same as data on the Betslip

  @RULES_automation_todo @regression
  Scenario: the online player should see the same data on the purchased mix system ticket (Prematch and Special) as on the Betslip (uid:5432fdd4-44d9-4726-b537-504427b24fe8)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    When the player selects "1/4,4/4" combinations on the Betslip
    And the player purchases an "ONLINE" sport "SYSTEM" ticket
    Then the "ONLINE" sport "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the Betslip
    And the data on the "DETAILS" is the same as data on the Betslip

  @RULES_automation_todo @regression
  Scenario: the online player should see the same data on the purchased mix simple ticket (Prematch, Inplay and Special) as on the Betslip (uid:e917e222-8068-4a44-b2f1-8bf3a7cabf2b)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    And the player has added "1" random "INPLAY" "FOOTBALL" events to the Betslip
    When the player purchases an "ONLINE" sport "SIMPLE" ticket
    Then the "ONLINE" sport "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the Betslip
    And the data on the "DETAILS" is the same as data on the Betslip

  @RULES_automation_todo @regression @acceptance
  Scenario: the online player should see the same data on the purchased mix system ticket (Prematch, Inplay and Special) as on the Betslip (uid:e3b36d8e-699c-42b8-971d-2ced1f58fc01)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    And the player has added "1" random "INPLAY" "FOOTBALL" events to the Betslip
    When the player selects "1/5,5/5" combinations on the Betslip
    And the player purchases an "ONLINE" sport "SYSTEM" ticket
    Then the "ONLINE" sport "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the Betslip
    And the data on the "DETAILS" is the same as data on the Betslip

  @RULES_automated @regression @acceptance
  Scenario: the online player should be able to purchase a Prematch simple ticket (uid:1358b00e-c0ce-4fd9-8fa0-0c496626f5c6)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player purchases an "ONLINE" sport "SIMPLE" ticket
    Then the "ONLINE" sport "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the ticket stake

  @RULES_automation_todo @regression @acceptance
  Scenario: the online player should be able to purchase a Prematch system ticket (uid:fc6e49d4-5e1c-45f6-979a-e3ffcc64a63d)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player selects "1/3,3/3" combinations on the Betslip
    And the player purchases an "ONLINE" sport "SYSTEM" ticket
    Then the "ONLINE" sport "SYSTEM" ticket is purchased
    And the player balance amount is subtracted by the ticket stake

  @RULES_automated @regression @acceptance
  Scenario: the online player should be able to purchase a Inplay simple ticket (uid:6da48565-61fc-407a-8f86-5435fa3edc4a)
    Given the player is logged in
    And the player has added "1" random "INPLAY" "FOOTBALL" events to the Betslip
    When the player purchases an "ONLINE" sport "SIMPLE" ticket
    Then the "ONLINE" sport "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the ticket stake

  @RULES_automation_todo @regression @acceptance
  Scenario: the online player should be able to purchase a Inplay system ticket (uid:d44c5ec1-f64d-4aaa-a288-2f2b7bd83830)
    Given the player is logged in
    And the player has added "3" random "INPLAY" "FOOTBALL" events to the Betslip
    When the player selects "1/3,3/3" combinations on the Betslip
    And the player purchases an "ONLINE" sport "SYSTEM" ticket
    Then the "ONLINE" sport "SYSTEM" ticket is purchased
    And the player balance amount is subtracted by the ticket stake

  @RULES_automation_todo @regression @acceptance @smoke
  Scenario: the online player should be able to purchase a mix Prematch, Inplay and Special simple ticket (uid:ff9a080b-0673-470e-925e-3f5997142387)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    And the player has added "1" random "INPLAY" "FOOTBALL" events to the Betslip
    When the player purchases an "ONLINE" sport "SIMPLE" ticket
    Then the "ONLINE" sport "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the ticket stake

  @RULES_automation_todo @regression @acceptance
  Scenario: the online player should be able to purchase a mix Prematch, Inplay and Special system ticket (uid:c88c3b6a-104b-4efe-b8e4-def7b6b9bc21)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    And the player has added "1" random "INPLAY" "FOOTBALL" events to the Betslip
    When the player selects "1/5,5/5" combinations on the Betslip
    And the player purchases an "ONLINE" sport "SYSTEM" ticket
    Then the "ONLINE" sport "SYSTEM" ticket is purchased
    And the player balance amount is subtracted by the ticket stake

  @RULES_automation_todo @regression
  Scenario: the online player should be able to purchase a simple ticket with the "16/16" combination option selected (uid:01fe3b56-d593-4fd2-93cd-7117d418d943)
    Given the player is logged in
    And the player has added "16" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player selects "16/16" combinations on the Betslip
    And the player purchases an "ONLINE" sport "SIMPLE" ticket
    Then the "ONLINE" sport "SIMPLE" ticket is purchased
