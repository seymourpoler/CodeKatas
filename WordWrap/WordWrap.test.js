let wordWrap = require('./WordWrap');

it('warp', () => {
    expect(wordWrap('hola', 10)).toBe('hola');
    expect(wordWrap('hola', 2)).toBe('ho\nla');
    expect(wordWrap('hola', 1)).toBe('h\no\nl\na');
});
