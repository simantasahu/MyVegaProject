import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map'

@Injectable()
export class FeatureService {

  constructor(private http: Http) { }
  
}
