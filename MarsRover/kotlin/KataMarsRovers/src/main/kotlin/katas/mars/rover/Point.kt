package katas.mars.rover

class Point(private val x: Int, private val y: Int) {

    fun getX(): Int {
        return x
    }

    fun getY(): Int {
        return y
    }

    fun forward(direction: Directions): Point {
        return when (direction) {
            Directions.North -> up()
            Directions.South -> down()
            Directions.West -> left()
            else -> right()
        }
    }

    fun backward(direction: Directions): Point {
        return when (direction) {
            Directions.North -> down()
            Directions.South -> up()
            Directions.West -> right()
            else -> left()
        }
    }

    private fun up(): Point {
        return Point(x, y + 1)
    }

    private fun down(): Point {
        return Point(x,y - 1)
    }

    private fun right(): Point {
        return Point(x + 1, y)
    }

    private fun left(): Point {
        return Point(x - 1, y)
    }
}