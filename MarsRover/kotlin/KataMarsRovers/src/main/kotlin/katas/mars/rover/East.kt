package katas.mars.rover

class East : Direction {
    override fun forward(position: Position): Position {
        return position.right()
    }

    override fun backward(position: Position): Position {
        return position.left()
    }
}