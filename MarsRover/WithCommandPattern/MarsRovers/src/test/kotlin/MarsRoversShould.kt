import org.assertj.core.api.Assertions.assertThat
import org.junit.jupiter.api.Test

class MarsRoversShould {
    @Test
    fun `create mars rovers with position and orientation`() {
        val latitude = 0
        val longitude = 0
        val orientation = "N"
        val marsRovers = MarsRovers(latitude, longitude, orientation)

        assertThat(marsRovers.isInPosition(latitude, longitude)).isTrue()
        assertThat(marsRovers.isOrientatedTo(Orientation.of(orientation))).isTrue()
    }

    @Test
    fun `facing north, move to up`(){
        val marsRovers = MarsRovers(0, 0, "N")

        marsRovers.move("F")

        assertThat(marsRovers.isInPosition(0, 1)).isTrue()
    }

    @Test
    fun `facing west, move to left`(){
        val marsRovers = MarsRovers(0, 0, "W")

        marsRovers.move("F")

        assertThat(marsRovers.isInPosition(0, -1)).isTrue()
    }

    @Test
    fun `facing south, move to up`(){
        val marsRovers = MarsRovers(0, 0, "S")

        marsRovers.move("B")

        assertThat(marsRovers.isInPosition(0, 1)).isTrue()
    }

    @Test
    fun `facing west, move to right`(){
        val marsRovers = MarsRovers(0, 0, "W")

        marsRovers.move("B")

        assertThat(marsRovers.isInPosition(1, 0)).isTrue()
    }
}

class MarsRovers(private val latitude: Int, private val longitude: Int, orientation: String) {

    private var orientation : Orientation = Orientation.of(orientation)
    private var position : Position = Position(latitude, longitude)

    fun isInPosition(latitude: Int, longitude: Int): Boolean {
        return this.position.latitude == latitude && this.position.longitude == longitude
    }

    fun isOrientatedTo(orientation: Orientation): Boolean {
        return this.orientation.equals(orientation);
    }

    fun move(movement: String) {
        val command = CommandFactory.create(movement, position, orientation)

        command.execute()
    }
}
