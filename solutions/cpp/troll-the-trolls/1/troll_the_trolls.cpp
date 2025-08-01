namespace hellmath {

    enum class AccountStatus {
        troll,
        guest, 
        user, 
        mod
    };
    enum class Action {
        read, 
        write,
        remove
    };

    bool display_post(AccountStatus posterStatus, AccountStatus ViewerStatus) {
        switch (posterStatus) {
            case AccountStatus::troll:
                return ViewerStatus == AccountStatus::troll;
            default:
                return true;
        }
    }

    bool permission_check(Action action, AccountStatus status) {
        switch (action) {
            case Action::read:
                return true;
            case Action::write:
                return status == AccountStatus::user || status == AccountStatus::troll || status == AccountStatus::mod;
            case Action::remove:
                return status == AccountStatus::mod;
            default:
                return false;
        }
    }

    bool valid_player_combination(AccountStatus player1, AccountStatus player2) {
        switch (player1) {
            case AccountStatus::guest:
                return false;
            case AccountStatus::troll:
                return player1 == player2;
            default:
                return player2 != AccountStatus::guest && player2 != AccountStatus::troll;
        }
    }

    bool has_priority(AccountStatus status1, AccountStatus status2) {
        switch (status1) {
            case AccountStatus::mod:
                return status2 != AccountStatus::mod;
            case AccountStatus::user:
                return status2 != AccountStatus::mod && status2 != AccountStatus::user;
            case AccountStatus::guest:
                return status2 != AccountStatus::mod && status2 != AccountStatus::user && status2 != AccountStatus::guest;
            default:
                return false;
        }
    }


}  // namespace hellmath