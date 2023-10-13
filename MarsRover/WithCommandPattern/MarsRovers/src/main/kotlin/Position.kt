data class Position(var latitude: Int, var longitude: Int) {
    fun up() {
        longitude += 1
    }

    fun left() {
        longitude -= 1;
    }

    fun down() {
        latitude -= 1
    }

    fun right() {
        TODO("Not yet implemented")
    }
}