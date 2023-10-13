package katas.mars.rover

import org.assertj.core.api.Assertions.assertThat
import org.junit.jupiter.api.Test

class RobotShould {
    //Consideration:
    //I avoid using parameterized tests, because I´ve trained name tests.
    //I don't write all possible scenarios, but most representative
    //I´ve faced very basic movement

    @Test
    fun `set up a robot in a position with a direction`(){
        val robot = Robot(0,0, "N");

        assertThat(robot).isNotNull()
        assertThat(robot.isInPosition(0, 0)).isTrue()
    }

    @Test
    fun `moves up when faces north and goes forward`(){
        val robot = Robot(0, 0, "N")

        robot.move("F")

        assertThat(robot.isInPosition(0, 1)).isTrue()
    }

    @Test
    fun `moves down when faces north and goes backward`(){
        val robot = Robot(0, 0, "N")

        robot.move("B")

        assertThat(robot.isInPosition(0, -1)).isTrue()
    }

    @Test
    fun `move down when face south and goes forward`(){
        val robot = Robot(0, 0, "S")

        robot.move("F")

        assertThat(robot.isInPosition(0, -1)).isTrue()
    }

    @Test
    fun `move up when face south and goes backward`(){
        val robot = Robot(0, 0, "S")

        robot.move("B")

        assertThat(robot.isInPosition(0, 1)).isTrue()
    }

    @Test
    fun `move right when faces east and goes forward`(){
        val robot = Robot(0, 0, "E")

        robot.move("F")

        assertThat(robot.isInPosition(1, 0)).isTrue()
    }

    @Test
    fun `move left when faces east and goes backward`(){
        val robot = Robot(0, 0, "E")

        robot.move("B")

        assertThat(robot.isInPosition(-1, 0)).isTrue()
    }

    @Test
    fun `move left when faces west and goes forward`(){
        val robot = Robot(0, 0, "W")

        robot.move("F")

        assertThat(robot.isInPosition(-1, 0)).isTrue()
    }

    @Test
    fun `move right when faces west and goes backward`(){
        val robot = Robot(0, 0, "W")

        robot.move("B")

        assertThat(robot.isInPosition(1, 0)).isTrue()
    }

    @Test
    fun `facing north then rotates to west and goes forward moves left`(){
        val robot = Robot(0, 0, "N")

        robot.move("W", "F")

        assertThat(robot.isInPosition(-1, 0)).isTrue()
    }

    @Test
    fun `facing north then rotate to south and goes forward moves down`(){
        val robot = Robot(0, 0, "N")

        robot.move("S", "F")

        assertThat(robot.isInPosition(0, -1)).isTrue()
    }

    @Test
    fun `facing north then rotate to south and goes forward moves down twice`(){
        val robot = Robot(0, 0, "N")

        robot.move("S", "F", "F")

        assertThat(robot.isInPosition(0, -2)).isTrue()
    }

    @Test
    fun `facing north then rotate to south and goes backward moves up`(){
        val robot = Robot(0, 0, "N")

        robot.move("S", "B")

        assertThat(robot.isInPosition(0, 1)).isTrue()
    }
}