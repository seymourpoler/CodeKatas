interface Orientation {
    fun forward(position: Position)
    fun backward(position: Position)

    companion object{
        fun of(orientation: String): Orientation {
            if(orientation == "N")
                return North()
            if(orientation == "W")
                return West()
            if(orientation == "S")
                return South()

            TODO()
        }
    }
}
