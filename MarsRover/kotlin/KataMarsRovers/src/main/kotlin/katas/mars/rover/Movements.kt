package katas.mars.rover

enum class Movements {
    Forward, Backward, North, South, East, West;

    companion object {
        fun from(movement: String): Movements{
            if(movement == "f"){
                return Movements.Forward
            }
            if(movement == "b") {
                return Movements.Backward
            }
            if(movement == "N"){
                return Movements.North
            }
            if(movement == "S"){
                return Movements.South
            }
            if(movement == "E"){
                return Movements.East
            }

            return Movements.West
        }
    }
}