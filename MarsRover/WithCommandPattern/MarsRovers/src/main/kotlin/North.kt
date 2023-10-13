class North : Orientation {
    override fun forward(position: Position) {
        position.up()
    }

    override fun backward(position: Position) {
        position.down()
    }

}