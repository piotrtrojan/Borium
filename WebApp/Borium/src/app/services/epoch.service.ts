import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { EpochDashboardDto } from '../dto/epoch/epoch-dashboard-dto';

@Injectable({
  providedIn: 'root'
})
export class EpochService {

  constructor(private http: HttpClient) { }

  public getEpoches(): Observable<Array<EpochDashboardDto>> {
    return this.http.get<Array<EpochDashboardDto>>(Constants.Endpoints.Epoch.GetDashboard);
  }

}
