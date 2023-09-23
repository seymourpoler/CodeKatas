package katas.mars.rover

import org.assertj.core.api.Assertions.assertThat
import kotlin.test.Test

class RobotShould {
    @Test
    fun `receive a starting point and direction`(){
        val x = 0
        val y = 0

        val robot = Robot(x, y, "N");

        assertThat(robot.getPositionX()).isEqualTo(x)
        assertThat(robot.getPositionY()).isEqualTo(y)
    }

    @Test
    fun `move to the north when direction is north and go forward`(){
        val x = 0
        val y = 0
        val robot = Robot(x, y, "N");

        robot.move("f")

        val expectedY = 1
        assertThat(robot.getPositionX()).isEqualTo(x)
        assertThat(robot.getPositionY()).isEqualTo(expectedY)
    }

    @Test
    fun `move to the north when direction is south and go backward`(){
        val x = 0
        val y = 0
        val robot = Robot(x, y, "S");

        robot.move("b")

        val expectedY = 1
        assertThat(robot.getPositionX()).isEqualTo(x)
        assertThat(robot.getPositionY()).isEqualTo(expectedY)
    }

    @Test
    fun `move to the north when direction is south, change to north and go forward`(){
        val x = 0
        val y = 0
        val robot = Robot(x, y, "S");

        robot.move("N", "f")

        val expectedY = 1
        assertThat(robot.getPositionX()).isEqualTo(x)
        assertThat(robot.getPositionY()).isEqualTo(expectedY)
    }

    @Test
    fun `move to the south when direction is north and go backward`(){
        val x = 0
        val y = 0
        val robot = Robot(x, y, "N");

        robot.move("b")

        val expectedY = -1
        assertThat(robot.getPositionX()).isEqualTo(x)
        assertThat(robot.getPositionY()).isEqualTo(expectedY)
    }

    @Test
    fun `move to the south when direction is south and go forward`(){
        val x = 0
        val y = 0
        val robot = Robot(x, y, "S");

        robot.move("f")

        val expectedY = -1
        assertThat(robot.getPositionX()).isEqualTo(x)
        assertThat(robot.getPositionY()).isEqualTo(expectedY)
    }

    @Test
    fun `move to the south when direction is north, change to south and go forward`(){
        val x = 0
        val y = 0
        val robot = Robot(x, y, "N");

        robot.move("S","f")

        val expectedY = -1
        assertThat(robot.getPositionX()).isEqualTo(x)
        assertThat(robot.getPositionY()).isEqualTo(expectedY)
    }

    @Test
    fun `move to the east when direction is east and go forward`(){
        val x = 0
        val y = 0
        val robot = Robot(x, y, "E");

        robot.move("f")

        val expectedX = 1
        assertThat(robot.getPositionX()).isEqualTo(expectedX)
        assertThat(robot.getPositionY()).isEqualTo(y)
    }

    @Test
    fun `move to the east when direction is west and go backward`(){
        val x = 0
        val y = 0
        val robot = Robot(x, y, "W");

        robot.move("b")

        val expectedX = 1
        assertThat(robot.getPositionX()).isEqualTo(expectedX)
        assertThat(robot.getPositionY()).isEqualTo(y)
    }

    @Test
    fun `move to the east when direction is north, change to east and go forward`(){
        val x = 0
        val y = 0
        val robot = Robot(x, y, "N");

        robot.move("E", "f")

        val expectedX = 1
        assertThat(robot.getPositionX()).isEqualTo(expectedX)
        assertThat(robot.getPositionY()).isEqualTo(y)
    }

    @Test
    fun `move to the west when direction is east and go backward`(){
        val x = 0
        val y = 0
        val robot = Robot(x, y, "E");

        robot.move("b")

        val expectedX = -1
        assertThat(robot.getPositionX()).isEqualTo(expectedX)
        assertThat(robot.getPositionY()).isEqualTo(y)
    }

    @Test
    fun `move to the west when direction is west and go forward`(){
        val x = 0
        val y = 0
        val robot = Robot(x, y, "W");

        robot.move("f")

        val expectedX = -1
        assertThat(robot.getPositionX()).isEqualTo(expectedX)
        assertThat(robot.getPositionY()).isEqualTo(y)
    }

    @Test
    fun `move to the west when direction is south, change to west and go forward`(){
        val x = 0
        val y = 0
        val robot = Robot(x, y, "S");

        robot.move("W","f")

        val expectedX = -1
        assertThat(robot.getPositionX()).isEqualTo(expectedX)
        assertThat(robot.getPositionY()).isEqualTo(y)
    }
}