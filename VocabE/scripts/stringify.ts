"use strict";
export default function(obj: object){
    return JSON.stringify(obj, null, '\t');
}