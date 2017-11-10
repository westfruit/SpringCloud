package com.vpclub.study.service;

import org.springframework.cloud.netflix.feign.FeignClient;

import org.springframework.stereotype.Service;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import java.util.List;

/**
 * Created by guowangcheng on 2017/11/9.
 */
@Service
@FeignClient(name = "eureka.client.net")
public interface NetValues {
    @RequestMapping(value = "/api/values", method = RequestMethod.GET)
    List<String> get();
}
