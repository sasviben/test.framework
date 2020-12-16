Feature: Logout


  Scenario: User should be able to logout from the Superbet page (uid:adbbfd9f-0044-4792-9f0c-86254c9ca08f)
    Given the online user is on the page "SPORT"
    When the user tries to logout
    Then the user is logged out
