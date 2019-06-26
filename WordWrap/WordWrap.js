function wordWrap(text, numberOfColumns){
    if(text.length < numberOfColumns){
        return text;
    }
    const wrapText = text.substring(0, numberOfColumns);
    const remainText = text.substring(numberOfColumns, text.length);
    return wrapText + '\n' + remainText;
    
    throw 'not implemented';
}

module.exports = wordWrap;

