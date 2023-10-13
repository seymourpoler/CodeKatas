class CommandFactory {
    companion object{
        fun create(movement: String, position: Position, orientation: Orientation): Command{
            if(movement == "F")
                return ForwardCommand(position, orientation)
            if(movement == "B")
                return BackCommand(position, orientation)

            TODO()
        }
    }
}