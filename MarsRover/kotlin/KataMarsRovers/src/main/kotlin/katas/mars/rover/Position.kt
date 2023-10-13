package katas.mars.rover

data class Position(val x: Int, val y: Int) {
    fun up() : Position {
        return Position(x, y + 1)
    }

    fun down(): Position {
        return Position(x, y - 1)
    }

    fun right(): Position {
        return Position(x + 1, y)
    }

    fun left(): Position {
        return Position(x-1, y)
    }
}