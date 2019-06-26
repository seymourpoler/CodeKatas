function wordWrap(text, numberOfColumns){
    if(text.length <= numberOfColumns){
        return text;
    }
    const wrappedText = text.substring(0, numberOfColumns);
    const remainingText = text.substring(numberOfColumns, text.length);
    return wrappedText + '\n' + wordWrap(remainingText, numberOfColumns);
}

module.exports = wordWrap;

