package com.vpclub.study.controller;

import com.vpclub.study.service.NetValues;
import org.springframework.beans.factory.annotation.Autowired;

import java.util.List;

/**
 * Created by guowangcheng on 2017/11/9.
 */
@RestController
@RequestMapping("/net")
public class ValuesController {
    @Autowired
    private NetValues netValues;

    @RequestMapping("/values")
    public List<String> home() {
        return netValues.get();
        //return null;
    }
}