package katas.mars.rover

enum class Directions {
    North, South, East, West;

    companion object{
        fun from(direction: String): Directions{
            if(direction == "N")
                return Directions.North
            if(direction == "S")
                return Directions.South
            if(direction == "W")
                return Directions.West
            return Directions.East
        }
    }
}