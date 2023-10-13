class South : Orientation {
    override fun forward(position: Position) {
        TODO("Not yet implemented")
    }

    override fun backward(position: Position) {
        position.up()
    }
}