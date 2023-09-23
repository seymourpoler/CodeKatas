package katas.mars.rover

class Robot(x: Int, y: Int, direction: String) {
    private var position : Point = Point(x, y)
    private var direction: Directions = Directions.from(direction)

    fun getPositionX(): Int {
        return position.getX()
    }

    fun getPositionY(): Int {
        return position.getY()
    }

    fun move(vararg actions: String) {
        actions.forEach{ action ->
            val movement = Movements.from(action)
            executeMovement(movement)
        }
    }

    private fun executeMovement(movement : Movements){
        when (movement) {
            Movements.North -> {
                direction = Directions.North
                return
            }
            Movements.South -> {
                direction = Directions.South
                return
            }
            Movements.East -> {
                direction = Directions.East
                return
            }
            Movements.West -> {
                direction = Directions.West
                return
            }
            Movements.Forward -> {
                position = position.forward(direction)
                return
            }
            else -> {
                position = position.backward(direction)
                return
            }
        }
    }
}