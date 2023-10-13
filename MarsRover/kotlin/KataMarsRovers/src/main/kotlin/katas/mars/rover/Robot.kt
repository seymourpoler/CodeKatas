package katas.mars.rover

class Robot(x: Int, y: Int, direction: String) {

    private var direction: Direction = Direction.of(direction)
    private var position : Position = Position(x, y)

    fun isInPosition(x:Int, y: Int): Boolean {
        return this.position == Position(x, y)
    }

    private fun forward() {
        position = direction.forward(position)
    }

    private fun backwards() {
        position = direction.backward(position)
    }

    private fun rotate(direction: String) {
        this.direction = Direction.of(direction)
    }

    fun move(vararg movements: String) {
        movements.forEach { movement ->
            move(movement)
        }
    }

    private fun move (movement: String){
        if(movement == "F") {
            forward()
            return
        }
        if(movement == "B") {
            backwards()
            return
        }
        rotate(movement)
    }
}