#include <string>

namespace log_line {
    std::string message(std::string log) {
        int message_pos = log.find(": ");
        return log.substr(message_pos + 2);
    }

    std::string log_level(std::string log) {
        int level_end_pos = log.find("]");
        return log.substr(1, level_end_pos - 1);
    }

    std::string reformat(std::string log) {
        return message(log) + " (" + log_level(log) +")";
    }
} // namespace log_line
