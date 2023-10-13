package katas.mars.rover

class North : Direction {
    override fun forward(position: Position): Position {
        return position.up()
    }

    override fun backward(position: Position): Position {
        return position.down()
    }
}