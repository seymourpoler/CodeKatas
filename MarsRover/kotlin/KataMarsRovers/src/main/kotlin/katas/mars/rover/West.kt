package katas.mars.rover

class West : Direction {
    override fun forward(position: Position): Position {
        return position.left()
    }

    override fun backward(position: Position): Position {
        return position.right()
    }
}