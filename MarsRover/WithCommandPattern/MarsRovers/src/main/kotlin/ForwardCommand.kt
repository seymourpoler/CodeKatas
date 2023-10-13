class ForwardCommand(var position: Position, var orientation: Orientation) : Command {
    override fun execute() {
        orientation.forward(position)
    }
}