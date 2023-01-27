"use strict";
export default function(obj: any){
    if(typeof obj == "string"){
        try {
            return JSON.parse(obj);
        } catch (error) {
            throw new Error(error);
        }
    }
    else{
        return obj;
    };
};