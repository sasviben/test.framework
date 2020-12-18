Feature: Online


  Scenario: the online player should be able to place a Lotto simple ticket (uid:2509a801-ed00-4105-a580-502222afb043)
    Given the player is logged in
    And the player has added "1" random "LOTTO" events to the Betslip
    When the player purchases an "ONLINE" "LOTTO" "SIMPLE" ticket
    Then the "ONLINE" "LOTTO" "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "LOTTO" Betslip
    And the data on the "DETAILS" is the same as data on the "LOTTO" Betslip
    And the player balance amount is subtracted by the "LOTTO" ticket stake

  Scenario: the online player should be able to place a Lotto system ticket (uid:ef51b301-07e3-4104-9155-87bb22c2c9f9)
    Given the player is logged in
    And the player has added "1" random "LOTTO" events to the Betslip
    When the player selects "RANDOM" combinations on the Betslip
    And the player purchases an "ONLINE" "LOTTO" "SYSTEM" ticket
    Then the "ONLINE" "LOTTO" "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "LOTTO" Betslip
    And the data on the "DETAILS" is the same as data on the "LOTTO" Betslip
    And the player balance amount is subtracted by the "LOTTO" ticket stake
