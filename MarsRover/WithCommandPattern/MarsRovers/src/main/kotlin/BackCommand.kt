class BackCommand(var position: Position, var orientation: Orientation) : Command {
    override fun execute() {
        orientation.backward(position)
    }
}
