package com.vpclub.study.service;

import java.awt.*;
import java.util.List;

/**
 * Created by guowangcheng on 2017/11/9.
 */
@FeignClient(name = "eureka.client.net")
public interface NetValues {
    @RequestMapping(value = "/api/values", method = RequestMethod.GET, consumes = PageAttributes.MediaType.APPLICATION_JSON_VALUE)
    List<String> get();
}
