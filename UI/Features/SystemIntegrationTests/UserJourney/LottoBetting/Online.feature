@LOTTO
Feature: Online


  Scenario: the online player should be able to place a Lotto simple ticket (uid:64af0544-d31b-415f-b0a1-98db5517234a)
    Given the player is logged in
    And the player has added "1" random "LOTTO" "FOOTBALL" events to the Betslip
    When the player purchases an "ONLINE" "LOTTO" "SIMPLE" ticket
    Then the "ONLINE" "LOTTO" "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "LOTTO" Betslip
    And the data on the "DETAILS" is the same as data on the "LOTTO" Betslip
    And the player balance amount is subtracted by the "LOTTO" ticket stake

  Scenario: the online player should be able to place a Lotto system ticket (uid:26c42fbe-f085-4ffe-96c8-edc5bdcfe67a)
    Given the player is logged in
    And the player has added "1" random "LOTTO" "FOOTBALL" events to the Betslip
    When the player selects "RANDOM" combinations on the Betslip
    And the player purchases an "ONLINE" "LOTTO" "SYSTEM" ticket
    Then the "ONLINE" "LOTTO" "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "LOTTO" Betslip
    And the data on the "DETAILS" is the same as data on the "LOTTO" Betslip
    And the player balance amount is subtracted by the "LOTTO" ticket stake
