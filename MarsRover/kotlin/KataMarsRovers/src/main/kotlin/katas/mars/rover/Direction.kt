package katas.mars.rover

interface Direction {
    fun forward(position: Position) : Position
    fun backward(position: Position) : Position

    companion object {
        fun of(direction: String): Direction { //factory method
            if(direction == "N")
                return North()
            if(direction == "E")
                return East()
            if(direction == "W")
                return West()
            return South()
        }
    }
}