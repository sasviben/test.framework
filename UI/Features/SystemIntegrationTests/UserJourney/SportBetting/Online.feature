Feature: Online


  Scenario: the online player should see the same data on the purchased mix simple ticket (Prematch and Inplay) as on the Betslip (uid:d88847a5-593c-470b-8fba-f7559b52f8e0)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "SPORT" Betslip
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the online player should see the same data on the purchased mix system ticket (Prematch and Inplay) as on the Betslip (uid:b093b256-a0f8-401c-8686-00c07e444683)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player selects "1/4,4/4" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SYSTEM" ticket
    Then the "ONLINE" "SPORT" "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "SPORT" Betslip
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the online player should see the same data on the purchased mix simple ticket (Prematch and Special) as on the Betslip (uid:db20457d-40ce-486c-97c6-2b2572b275de)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    When the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "SPORT" Betslip
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the online player should see the same data on the purchased mix system ticket (Prematch and Special) as on the Betslip (uid:1500d6d4-e8ba-4fff-a2fb-3a86c23533f2)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    When the player selects "1/4,4/4" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SYSTEM" ticket
    Then the "ONLINE" "SPORT" "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "SPORT" Betslip
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the online player should see the same data on the purchased mix simple ticket (Prematch, Inplay and Special) as on the Betslip (uid:60c6af50-2293-47b8-88f4-36589be8b3d1)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "SPORT" Betslip
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip
    And the player balance amount is subtracted by the "SPORT" ticket stake

  Scenario: the online player should see the same data on the purchased mix system ticket (Prematch, Inplay and Special) as on the Betslip (uid:411be173-04fd-4205-b535-954b3377fe22)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player selects "1/5,5/5" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SYSTEM" ticket
    Then the "ONLINE" "SPORT" "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "SPORT" Betslip
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the online player should be able to purchase a Prematch simple ticket (uid:5a13ad1d-9608-4eed-867e-5c590fb0b4f2)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    When the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the "SPORT" ticket stake

  Scenario: the online player should be able to purchase a Prematch system ticket (uid:c0221903-cf4b-435c-9e5a-642606cd64b6)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    When the player selects "1/3,3/3" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SYSTEM" ticket
    Then the "ONLINE" "SPORT" "SYSTEM" ticket is purchased
    And the player balance amount is subtracted by the "SPORT" ticket stake

  Scenario: the online player should be able to purchase a Inplay simple ticket (uid:1eb732f8-58ed-4ae5-9091-4db297f4f6bb)
    Given the player is logged in
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the "SPORT" ticket stake

  Scenario: the online player should be able to purchase a Inplay system ticket (uid:3d79ad5a-a9f0-4b2a-97fe-f6866dfde54e)
    Given the player is logged in
    And the player has added "3" random "INPLAY" events to the Betslip
    When the player selects "1/3,3/3" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SYSTEM" ticket
    Then the "ONLINE" "SPORT" "SYSTEM" ticket is purchased
    And the player balance amount is subtracted by the "SPORT" ticket stake

  Scenario: the online player should be able to purchase a mix Prematch, Inplay and Special simple ticket (uid:7166a812-cd5a-4d99-b732-02c223d99f32)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the "SPORT" ticket stake

  Scenario: the online player should be able to purchase a mix Prematch, Inplay and Special system ticket (uid:c946596a-9c00-4570-a418-74b97e105e08)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player selects "1/5,5/5" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SYSTEM" ticket
    Then the "ONLINE" "SPORT" "SYSTEM" ticket is purchased
    And the player balance amount is subtracted by the "SPORT" ticket stake
