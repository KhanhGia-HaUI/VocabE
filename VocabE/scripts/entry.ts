"use strict";
import { disconnect } from "process";
namespace VocabE.Entry {
    try {
        FileReader.LOADING;
    } catch (error) {
        throw new Error(error);
    };
    const FileReader_OK = FileReader.DONE ? true : false;
    if(FileReader_OK){
        throw new EventTarget();
    }
    disconnect();
}