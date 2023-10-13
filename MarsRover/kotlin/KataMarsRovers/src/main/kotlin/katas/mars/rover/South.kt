package katas.mars.rover

class South : Direction {
    override fun forward(position: Position): Position {
        return position.down()
    }

    override fun backward(position: Position): Position {
        return position.up()
    }
}