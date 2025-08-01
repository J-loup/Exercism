namespace targets {

    class Alien {
    public:
        Alien(int x , int y ) : x_coordinate(x), y_coordinate(y)  {}

        int get_health() {
            return this->health;
        }

        bool hit(){
            this->health--;
            return true;
        }

        bool is_alive() {
            return this->health > 0;
        }

        bool teleport(int x, int y) {
            this->x_coordinate = x;
            this->y_coordinate = y;
            return true;
        }

        bool collision_detection(const Alien& other) {
            return this->x_coordinate == other.x_coordinate && this->y_coordinate == other.y_coordinate;
        }

        int x_coordinate;
        int y_coordinate;
    private:
        int health = 3;
    };

}  // namespace targets