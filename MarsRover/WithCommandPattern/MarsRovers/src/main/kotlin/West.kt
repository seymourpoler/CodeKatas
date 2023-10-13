class West : Orientation  {
    override fun forward(position: Position) {
        position.left()
    }

    override fun backward(position: Position) {
        position.right()
    }
}