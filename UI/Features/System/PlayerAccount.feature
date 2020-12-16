Feature: Player account


  Scenario: the prematch user balance should be higher than the predefined limit (uid:9d6f73dd-f452-47c7-a8d6-3d24c45c4c52)
    Given the "PREMATCH" user is logged in
    When the user checks the balance amount
    Then the balance amount should be higher than the "1728.00"

  Scenario: the inplay user balance should be higher than the predefined limit (uid:2fb889db-deba-44df-8abb-29c50b2b5a71)
    Given the "INPLAY" user is logged in
    When the user checks the balance amount
    Then the balance amount should be higher than the "1728.00"

  Scenario: the lotto user balance should be higher than the predefined limit (uid:7c3ed7f3-96c0-4b17-8c4c-c63199ffb7da)
    Given the "LOTTO" user is logged in
    When the user checks the balance amount
    Then the balance amount should be higher than the "1728.00"

  Scenario: the games user balance should be higher than the predefined limit (uid:035ea797-3e61-47ad-8455-605818caa7ca)
    Given the "GAMES" user is logged in
    When the user checks the balance amount
    Then the balance amount should be higher than the "1728.00"
